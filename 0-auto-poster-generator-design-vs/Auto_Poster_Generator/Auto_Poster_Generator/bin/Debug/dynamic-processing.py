import textwrap                               # Import textwrap, use it for wrap the text.
from PIL import ImageFont, ImageDraw, Image   # The main module, use it for image processing.
import os                                     # for os releted works

first_iteration = 0
secound_iteration = 0

image_path = ""

input_data = []
all_content_data = []


with open('dynamic_config.txt') as length_file:
  
  for index, line in enumerate(length_file):
    data = line.strip().split("|")
    first_iteration = data[0]
    secound_iteration = data[1]
    image_path = data[2].strip()

with open('dynamic_input_data.txt') as content_file:
  
  for index, line in enumerate(content_file):
    data = line.strip().split("|") 

    if len(data) == 11:
	    input_data.append([data[0],data[1], data[2], data[3], data[4],data[5],data[6],data[7],data[8],data[9],data[10]])

	    with open(data[10].strip()) as sub_file:

	    	dummy_list = []

	    	for index, line in enumerate(sub_file):
		    	sub_data = line.strip()
		    	dummy_list.append(sub_data)

	    	all_content_data.append(dummy_list)

for x in range(int(first_iteration)):

	template = Image.open(os.path.join(os.getcwd(), image_path))
	drawing_object = ImageDraw.Draw(template)  # drawing object

	for y in range(int(secound_iteration)):

		font_size = int(input_data[y][5])

		y1, y2 = int(input_data[y][0]), int(input_data[y][1])
		x1, x2 = int(input_data[y][2]), int(input_data[y][3])
		
		box_width =  x2 - x1
		box_height = y2 - y1

		cert_text = all_content_data[y][x]

		while True:
			
			given_font = ImageFont.truetype(font=f'{input_data[y][4].strip()}', size=font_size)

			text_width, text_height = drawing_object.textsize(cert_text, font=given_font) 
			per_char_avg_width = text_width // len(cert_text)  
			
			size_of_containment = (box_width - (box_width / 15)) // per_char_avg_width

			wrapped_text = textwrap.fill(cert_text, width=int(size_of_containment))

			total_line_hight_of_text = len(wrapped_text.split('\n')) * text_height # 300


			if total_line_hight_of_text < box_height:

        #tw, th = draw.textsize(wrapped_text, font = print_font)
        #(tw /2) (th /2)

				color = input_data[y][8]
				

				rgb_value = color.strip().split(',')

				r =  int(rgb_value[0])
				g =  int(rgb_value[1])
				b =  int(rgb_value[2])

				opacity = int(input_data[y][9])

				drawing_object.text((x1 + (box_width / 2), y1 + (box_height / 2)), wrapped_text, font=given_font, fill=(r, g, b, opacity), anchor = 'mm', stroke_width = int(input_data[y][7].strip()), align= f"{input_data[y][6].strip()}")
	            
				print("Processing...")
	            
				break

			font_size = font_size - 1

	template.save(f'dynamic-generated-images/{x}.png')
