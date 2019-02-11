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
