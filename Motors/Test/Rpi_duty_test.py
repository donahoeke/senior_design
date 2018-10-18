import RPi.GPIO as io
io.setmode(io.BCM) #The GPIO.BCM option means that you are referring to the pins by the "Broadcom SOC channel" number (see diagram 1 - they are the green GPIO pins)
 
#Configures GPIO Pin 4 as an output
o_pin = 4
io.setup(o_pin, io.OUT)

#Function to set the different files with the right properties
#STOLEN from online
def set(property, value):
    try:
        f = open("/sys/class/rpi-pwm/pwm0/" + property, 'w')
        f.write(value)
        f.close()   
    except:
        print("Error writing to file: " + property + " value: " + value)
        
#Sets duty cycle of the signal. In the future, I image it having inputs for
#options for angle wanted instead of duty cycle
def setDutyCyle(duty):
    io.output(o_pin, True)  
    set("duty", str(duty))
    
#Configures signal to have these settings (see table)    
set("delayed", "0")
set("mode", "pwm")
set("frequency", "50")
set("active", "1")

#Loops through continuously in the program 
while True:
    cmd = raw_input("Duty Cycle :")
    duty = cmd[0]
    if duty == "":
        io.output(o_pin, False)  
    else:
        setDutyCyle(duty)
