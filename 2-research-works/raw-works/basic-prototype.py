import os
from PIL import Image, ImageDraw, ImageFont

list_of_numbers = []

list_of_titles = []

with open('number-data.txt') as f:
  for line in f:
  	list_of_numbers.append(line.strip())

with open('data-without-number.txt') as f:
  for line in f:
  	list_of_titles.append(line.strip())     

W, H = (1898, 813)

font_type = ImageFont.truetype("calibri.ttf", 150)

for index, number in enumerate(list_of_numbers):
	template = Image.open(os.path.join(os.getcwd(),"template.png"))
	d1 = ImageDraw.Draw(template)
	d1.text((565,515),number, fill=(0, 0, 0), font = font_type)
	template.save(f'generated-data/{index}.png')
	print(f'Processing {index+1} / {len(list_of_numbers)}')

	

