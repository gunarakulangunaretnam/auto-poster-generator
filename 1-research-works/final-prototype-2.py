import textwrap
from PIL import ImageFont, ImageDraw, Image
import os


data_point = []


with open('input_data.txt') as f:
  
  for line in f:
    input_data = line.strip().split("|")

    with open(input_data[5].strip()) as f:

        sample_data_point = []

        for line in f:
            sample_data_point.append(line.strip())

        data_point.append(sample_data_point)


    font_size = input_data[4]

    # Coordinates of the corners of the box in the template
    y1, y2 = input_data[0], input_data[1]
    x1, x2 = input_data[2], input_data[3]

    # Height and width of the box calculated from the coordinates
    box_width =  x2 - x1
    box_height = y2 - y1

    # Text to be printed
    cert_text = "Python is an interpreted high-level general-purpose programming language.Python is an interpreted."

    template = Image.open(os.path.join(os.getcwd(), "template.png"))
    drawing_object = ImageDraw.Draw(template)  # drawing object


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
            template.save('test.png')
            
            print(f'Font size: {font_size}')
            
            break


        font_size = font_size - 1


        

print(data_point)