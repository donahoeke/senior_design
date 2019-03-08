import RPi.GPIO as IO

import time



#BCM Pin 18

pin = 18



IO.setwarnings(False)

IO.setmode (IO.BCM)

IO.setup(pin,IO.OUT)



#Starts 50 Hz PWM signal at 10% duty cycle

signal = IO.PWM(pin,50)

signal.start(10)

time.sleep(0.7)

#Turns signal off

signal.ChangeDutyCycle(0)



while 1:

        #Takes input from user (duty cycle: 1-100; ideally 3-12% for motors)

        duty = input("Duty Cycle: ")

        

        try:

                signal.ChangeDutyCycle(int(duty))

                time.sleep(0.7)

                signal.ChangeDutyCycle(0)

        except:

                print("Duty cycle not valid. Try again.")
