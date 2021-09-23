import textwrap
from PIL import ImageFont, ImageDraw, Image
import os

first_iteration = 0
secound_iteration = 0

content_data = []
coordinate_data = []

with open('length.txt') as length_file:
  
  for index, line in enumerate(length_file):
    data = line.strip().split("|")
    first_iteration = data[0]
    secound_iteration = data[1]


with open('input_data.txt') as content_file:
  
  for index, line in enumerate(content_file):
    data = line.strip().split("|")
    coordinate_data.append([data[0],data[1], data[2], data[3], data[4]])

    with open(data[5].strip()) as sub_file:

    	dummy_list = []

    	for index, line in enumerate(sub_file):
	    	sub_data = line.strip()
	    	dummy_list.append(sub_data)

    	content_data.append(dummy_list)
			

for x in range(int(first_iteration)):

	template = Image.open(os.path.join(os.getcwd(), "template.png"))
	drawing_object = ImageDraw.Draw(template)  # drawing object

	for y in range(int(secound_iteration)):

		font_size = int(coordinate_data[y][4])

		y1, y2 = int(coordinate_data[y][0]), int(coordinate_data[y][1])
		x1, x2 = int(coordinate_data[y][2]), int(coordinate_data[y][3])
		
		box_width =  x2 - x1
		box_height = y2 - y1

		cert_text = content_data[y][x]

		while True:

			given_font = ImageFont.truetype(font='./times.ttf', size=font_size)

			text_width, text_height = drawing_object.textsize(cert_text, font=given_font)
			per_char_avg_width = text_width // len(cert_text) #avg char with
			
			size_of_containment = (box_width - (box_width / 15)) // per_char_avg_width

			wrapped_text = textwrap.fill(cert_text, width=size_of_containment)

			total_line_hight_of_text = len(wrapped_text.split('\n')) * text_height

				
			if total_line_hight_of_text < box_height:

	            #tw, th = draw.textsize(wrapped_text, font = print_font)
	            #(tw /2) (th /2)
				drawing_object.text((x1 + (box_width / 2), y1 + (box_height / 2)), wrapped_text, font=given_font, fill=(255, 0, 0, 255), anchor = 'mm' , align= "center")
	            
				print(f'Font size: {font_size}')
	            
				break


				font_size = font_size - 1

	template.save(f'generated-data/{x}.png')


		














