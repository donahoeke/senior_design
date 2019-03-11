import RPi.GPIO as GPIO
from lib_nrf24 import NRF24
import time
import spidev
import RPi.GPIO as IO

#BCM Pins (PWM0) :18,12 
pin0 = 18
pin1 =12
IO.setwarnings(False)
IO.setmode (IO.BCM)
IO.setup(pin0,IO.OUT)
IO.setup(pin1,IO.OUT)

#Starts 50 Hz PWM signal at 10% duty cycle
signal0 = IO.PWM(pin0,50)
signal0.start(10)

signal1 = IO.PWM(pin1,50)
signal1.start(10)

time.sleep(0.7)

#Turns signal off
signal0.ChangeDutyCycle(0)
signal1.ChangeDutyCycle(0)

#Setting the GPIO for pin connections
GPIO.setmode(GPIO.BCM)

#Setting the addresses for the receive and sent
pipes = [[0xE8, 0xE8, 0xF0, 0xF0, 0xE1], [0xF0, 0xF0, 0xF0, 0xF0, 0xE1]]
#Creating the instance for the radio
radio = NRF24(GPIO, spidev.SpiDev())
#Starting the radio for the CE and CSN pins
radio.begin(0, 17)
#Setting the payload size and the maximum is 32
radio.setPayloadSize(32)
#Setting the channel to 76 but there is multiple channels you can use
radio.setChannel(0x76)
#Setting the data rate to 1MBPS
radio.setDataRate(NRF24.BR_1MBPS)
#Setting power amplifier level to minimum, this is the receive side
radio.setPALevel(NRF24.PA_MIN)
#Setting the auto acknowledge to true
radio.setAutoAck(True)
radio.enableDynamicPayloads()
#Enables acknowledgement payload that sends a message back saying "Yes I did receive this message"
radio.enableAckPayload()
#This is the receiving side, need to have the the address set to the receving side
radio.openReadingPipe(1, pipes[1])
#This will print the details of the antenna on setup
radio.printDetails()
#Set the radio to begin receiving a message
radio.startListening()


#This loop will have the radio sit and wait until a message is received
while True:
	#If no message received, go to sleep then wake up and check again
	while not radio.available(0):
		time.sleep(1/100)
	#Creating an instance to store the received message into
	receivedMessage = []
        
	#Read what is received
	radio.read(receivedMessage, radio.getDynamicPayloadSize())

	#Display what is received 
	print("Received: {}".format(receivedMessage))

	#The data that is sent across this radio is a byte at a time up to 32 byte payload and a byte is made up of 8 bits
	#and 8 bits can only be a number between 0 and 255.  So anything that we get will be 32 numbers between 0 and 255.  To get a string you encode your
	#string characters into a unicode, so we will need to decode the received message into strings
	#print("Translating our received message into unicode characters...")

	#Creating an instance for an empty string to store that received message into
	string = ""

	#for n in receivedMessage:
	#if (n >= 32 and n <= 126):
	#Decodes the byte value n into letters
	#string += chr(n)
	#print("Our received message decodes to: {}".format(string))

	n = receivedMessage[0]

	position = float(n)
	print("position "+ str(position))

	#Changes position of first motor
	if (position >= 103 and position <= 113):
		position1 = position - 100
		signal0.ChangeDutyCycle(position1)
		time.sleep(0.2)
		signal0.ChangeDutyCycle(0)
		print("Motor position 1: " + str(position1))
	
	#Changes position of second motor
	if(position >=203 and position <= 213):
		position2 = position - 200
		signal1.ChangeDutyCycle(position2)
		time.sleep(0.2)
		signal1.ChangeDutyCycle(0)
		print("Motor position 2: " + str(position2))
