import os
import cv2

list_of_numbers = []

list_of_title = []

with open('number-data.txt') as f:
  for line in f:
  	list_of_numbers.append(line.strip())


with open('data-without-number.txt') as f:
  for line in f:
  	list_of_title.append(line.strip())


for index, textNumber in enumerate(list_of_numbers):
	template = cv2.imread("template.png")
	cv2.putText(template, textNumber, (557,625), cv2.FONT_HERSHEY_SIMPLEX, 4, (0, 0, 0), 4, cv2.LINE_AA)
	cv2.putText(template, "English", (440,150), cv2.FONT_HERSHEY_DUPLEX, 2, (255, 255, 255), 2, cv2.LINE_AA)
	cv2.putText(template, list_of_title[index], (85,326), cv2.FONT_HERSHEY_SIMPLEX, 1.4, (255, 255, 255), 2, cv2.LINE_AA)
	cv2.imwrite(f'generated-data/{textNumber}.jpg', template)
