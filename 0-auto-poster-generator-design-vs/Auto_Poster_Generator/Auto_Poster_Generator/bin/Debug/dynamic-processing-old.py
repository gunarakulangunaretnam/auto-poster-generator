import textwrap                               # Import textwrap, use it for wrap the text.
from PIL import ImageFont, ImageDraw, Image   # The main module, use it for image processing.
import os                                     # for os releted works

number_boxes = 0                              # Number of boxes that the template image will have.
number_of_sentances = 0												# Number of sentances list that the file will have.
template_image_path = ""                      # Template image path

input_data = []                               # This list contains input data (Ex: coordinates, font-size, color, align, stroke, sentances's text file and etc) for one box.
all_content_data = []                 			  # This list contains all of the sentances from the given input_data that extracts from the sentances's text file.



with open('dynamic_config.txt') as file_count:    # Open the dynamic_config.txt
  
  for index, line in enumerate(file_count):       # Loop the content in the dynamic_config.txt line by line.
    data = line.strip().split("|")                # Split by | and remove white spaces at both side.
    number_of_sentances = data[0]                 # Store the number of sentances for iteration (Sentances count) 
    number_boxes = data[1]                        # Number of boxes in the poster (Elements with coordinates)
    template_image_path = data[2].strip()         # Templace image path
    

with open('dynamic_input_data.txt') as content_file:   # Open the dynamic_input_data.txt
  
  for index, line in enumerate(content_file):          # Loop the input content_file
    data = line.strip().split("|")                     # Split by | and remove white spaces at both side.

    if len(data) == 11:                                # If the data has 11, it allows to go for next step.
	    
	    input_data.append([data[0],data[1], data[2], data[3], data[4],data[5],data[6],data[7],data[8],data[9],data[10]])  # We store the input data (Parameters such as color, font-size, text file path, stroke, font-family)

	    with open(data[10].strip()) as sub_file:         # Open the given sentacens content files.

	    	dummy_list = []

	    	for index, line in enumerate(sub_file):
		    	sub_data = line.strip()
		    	dummy_list.append(sub_data)

	    	all_content_data.append(dummy_list)


for x in range(int(number_boxes)):

	template = Image.open(os.path.join(os.getcwd(), template_image_path))
	drawing_object = ImageDraw.Draw(template)  # drawing object

	for y in range(int(number_of_sentances)):

		font_size = int(input_data[y][5])

		y1, y2 = int(input_data[y][0]), int(input_data[y][1])
		x1, x2 = int(input_data[y][2]), int(input_data[y][3])
		
		box_width =  x2 - x1
		box_height = y2 - y1

		cert_text = all_content_data[y][x]

		while True:
			
			given_font = ImageFont.truetype(font=f'{input_data[y][4].strip()}', size=font_size)

			text_width, text_height = drawing_object.textsize(cert_text, font=given_font)
			per_char_avg_width = text_width // len(cert_text) #avg char with
			
			size_of_containment = (box_width - (box_width / 15)) // per_char_avg_width

			wrapped_text = textwrap.fill(cert_text, width=int(size_of_containment))

			total_line_hight_of_text = len(wrapped_text.split('\n')) * text_height


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
