import picamera
import time

camrea = picamera.PiCamera()
camera.vflip = True #vertically flips the image so it is right side up


#This goes through all of the image effects that the RPi can apply to images

for effect in camera.IMAGE_EFFECTS:
  filename = "image_%s.jpg" % effect #this names the file with the effect that was used
  camera.image_effect = effect
  camera.capture(filename)
  time.sleep(1)
