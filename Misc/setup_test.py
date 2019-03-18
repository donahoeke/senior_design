#check to see that both cameras are supported and detected. 
pi@raspberrypi $ vcgencmd get_camera

#it should come back that two cameras are supported and detected. If this does not happen, continue troubleshooting

#goes to Desktop directory
pi@raspberrypi $ cd /home/pi/Desktop/
#creates a new directory called CameraPictures
pi@raspberrypi ~/Desktop $ mkdir Pictures 
#goes to CameraPictures directory
pi@raspberrypi ~/Desktop $ cd Pictures
#open a program to type in within the CameraPictures directory
pi@raspberrypi ~/Desktop/CameraPictures $nano camexp.py
#type program, control X to exit then hit Y and enter

#execute program
pi@raspberrypi ~/Desktop/CameraPictures $ python camexp.py
