import picamera
import time
import RPi.GPIO as GPIO


#GPIO.setmode(GPIO.BOARD)
#GPIO.setup (37,GPIO.IN)
camera = picamera.PiCamera()
#camera = picamera.PiCamera(stereo_mode='side-by-side') #for the
compute module only
#z = 0
#n = 0

camera.capture("testplan.bmp")
time.sleep(2)
camera.start_recording("testvid.h264")
time.sleep(5)
camera.stop_recording






#while True:
#       if GPIO.input(37) == 0:
#               count = 0;
#       else:
#               if (count==1):
#                       x = "image"
#                       y = ".bmp"
#                       r = str(n)
#                       filename = x+r+y
#                       camera.capture(filename)
#                       n = n +1
#               
#               else:
#                       count = count+1




#for effect in camera.IMAGE_EFFECTS:
#       filename = 'image_%s.bmp' % effect
#       camera.image_effect = effect
#       camera.capture(filename)
#       time.sleep(1)

#in LX Terminal
#to convert .h256 to .avi
#avconv -r 30 -i exp.h264 -r 30 output.avi
