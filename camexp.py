import picamera
import time

camera = picamera.PiCamera(mode = stereo "side-by-side")

camera.capture("test_plan.bmp")

time.sleep(2)

camera.start_recording("testvid.h264")
time.sleep(5)
camera.stop_recording()
