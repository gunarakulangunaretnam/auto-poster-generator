import textwrap                               # Import textwrap, use it for wrap the text.
from PIL import ImageFont, ImageDraw, Image   # The main module, use it for image processing.
import os                                     # for os releted works, getting current working directory

first_iteration = 0                           # Number of sentances in a input file.  (It comes from dynamic_config.txt) (Number of images need to created)
secound_iteration = 0                         # Number of boxes in a teamplate image  (boxs means elements) (It comes from dynamic_config.txt).

image_path = ""                               # Template image path

input_data = []																# This list contains another list which has the parameters of the sentances (Color, Font-size, Align, stroke, opacity)                  [[23,34,45,67, red, center],[32,43,43,23, green, left]]
all_content_data = []													#	This list contains another list which has sentances that has be written in the template image according to the input file parameters. [["python", "Java", "PhP"],["Ruby", "Perl", "Dart" ]]


with open('dynamic_config.txt') as length_file:    # Open dynamic_config.txt file for template configuration
  
  for index, line in enumerate(length_file):       # Loop dynamic_config.txt 
    data = line.strip().split("|")                 # Split by "|" remove whitespace and store in a data list
    first_iteration = data[0]											 # Store the first iteration   (Number of sentances that find in the first input sentance file)
    secound_iteration = data[1]                    # Store the secound iteration (Number of boxes (elements) that find in the template)
    image_path = data[2].strip()

with open('dynamic_input_data.txt') as content_file:  # Open dynamic_input_data.txt file.
  
  for index, line in enumerate(content_file):					# Loop dynamic_input_data.txt
    data = line.strip().split("|")                    # Split by "|" remove whitespace and store in a data list

    if len(data) == 11:                               # If it has 11 parameters, (11 is correct)

	    input_data.append([data[0],data[1], data[2], data[3], data[4],data[5],data[6],data[7],data[8],data[9],data[10]])  # Store the parameters in a nexted list called input_data[] ex: [[23,34,45,67, red, center],[32,43,43,23, green, left]]

	    with open(data[10].strip()) as sub_file: 				# Open the sentance file that finds as a input parameter data[10] ex:- dynamic-content-files/number-data.txt

	    	dummy_list = []                               # Create dummy_list to store temp local data.

	    	for index, line in enumerate(sub_file):				# Loop subfile ex:- dynamic-content-files/number-data.txt
		    	sub_data = line.strip()									    # Split by "|" remove whitespace and store in a data list
		    	dummy_list.append(sub_data)									# Append each sentances to the dummy_list.

	    	all_content_data.append(dummy_list)						# Add this dummy_list to the main global list called all_content_data [["python", "Java", "PhP"],["Ruby", "Perl", "Dart" ]]



# Bellow, main image processing take place.

for x in range(int(first_iteration)):  												  # Loop first iteration (Number of sentances in a input file.) (Number of images need to created)

	template = Image.open(os.path.join(os.getcwd(), image_path))  # Get the template image.
	drawing_object = ImageDraw.Draw(template)  										# Create a drawing object.   

	for y in range(int(secound_iteration)):                       # Loop the secound iteration in the first iternation. (Number of boxes in a teamplate image)

		font_size = int(input_data[y][5])														# Get font-size. 

		y1, y2 = int(input_data[y][0]), int(input_data[y][1])       # Get y1, y2 coordinates
		x1, x2 = int(input_data[y][2]), int(input_data[y][3])				# Get x1, x2 coordinates
		
		box_width =  x2 - x1                                   # Via subtracting the x2 - x1, we get the box with
		box_height = y2 - y1																	 # Via subtracting the y2 - y1, we get the box with			

		print_content = all_content_data[y][x]								 # Get print content.			


		while True:																						 # This is a infinite loop, it is for font resizing function.
			
			given_font = ImageFont.truetype(font=f'{input_data[y][4].strip()}', size=font_size)   # Set the font via giving font_size and name.

			text_width, text_height = drawing_object.textsize(print_content, font=given_font)     # Get the width and hight of the text
			per_char_avg_width = text_width // len(print_content)                                 # Get avg width of a char. 
			
			size_of_containment = (box_width - (box_width / 15)) // per_char_avg_width						# Calculate the ammount of text that could be fit into box. (box_width / 15) is for padding inside the box

			wrapped_text = textwrap.fill(print_content, width=int(size_of_containment))           # Based on the size_of_containment, we wrap the text.

			total_line_hight_of_text = len(wrapped_text.split('\n')) * text_height 								# Calculate the text height to fit into the box. (We are not allowing it to go beyound the box).


			if total_line_hight_of_text < box_height:																							# If total_line_hight_of_text if greater than the box_height, we resize the font-size to be fit. 

        #tw, th = draw.textsize(wrapped_text, font = print_font)
        #(tw /2) (th /2)

				color = input_data[y][8]															# Get color.
				

				rgb_value = color.strip().split(',')									# Split the color as RGB.

				r =  int(rgb_value[0])															  # Assign r value
				g =  int(rgb_value[1])																# Assign g value
				b =  int(rgb_value[2])																# Assign b value

				opacity = int(input_data[y][9])                       # Get opacity

				drawing_object.text((x1 + (box_width / 2), y1 + (box_height / 2)), wrapped_text, font=given_font, fill=(r, g, b, opacity), anchor = 'mm', stroke_width = int(input_data[y][7].strip()), align= f"{input_data[y][6].strip()}") # We do drawing.
	      
				try:
				  file = open("process_status.txt", "w") # Create a file for process status.
				  file.write(str(x))                     # Write process status to the file
				  file.close()													 # Close the file.
				except Exception as e:                   
					print(e)

				print("Processing {} / {}".format(x, first_iteration))
				
				break # After drawing, break it.

			font_size = font_size - 1

	template.save(f'dynamic-generated-images/{x}.png') # We save the image.
