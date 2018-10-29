import RPi.GPIO as IO
import time

pin = 18

IO.setwarnings(False)
IO.setmode (IO.BCM)

IO.setup(pin,IO.OUT)

signal = IO.PWM(pin,50)
signal.start(0)

while 1:
        signal.ChangeDutyCycle(x)
