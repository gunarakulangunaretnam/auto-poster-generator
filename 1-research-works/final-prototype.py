import textwrap
from PIL import ImageFont, ImageDraw, Image
import os


font_size = 30

# Coordinates of the corners of the box in the template
y1, y2 = 187, 440
x1, x2 = 63, 1045

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


    

