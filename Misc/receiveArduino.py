import RPi.GPIO as GPIO
from lib_nrf24 import NRF24
import time
import spidev

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

#This is the receiving side, need to have the address set to the receiving side
radio.openReadingPipe(1, pipes[1])

#This will print the details of the antenna on setup
radio.printDetails()

#Set the radio to begin receiving a message
radio.startListening()

#This loop will have the radio sit and wait unil a message is received
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
        #and 8 bits can only be a number between 0 and 255.  So anything that we get will be 32 numbers between 0 and 255
        #string characters into a unicode, so we will need to decode the received message into strings
        print("Translating our received message into unicode characters...")
        
        #Creating an instance for an empty string to store that received message into
        string = ""
        
        for n in receivedMessage:
                if (n >= 32 and n <= 126):
                        #Decodes the bye value n into letters
                        string += char(n)
                  
        print("our received message decodes to: {}".format(string))
