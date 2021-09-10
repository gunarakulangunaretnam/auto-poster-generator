import textwrap
from PIL import ImageFont, ImageDraw, Image
import os


print_font = ImageFont.truetype(font='./times.ttf', size=50)
im = template = Image.open(os.path.join(os.getcwd(), "template.png"))  # Read
draw = ImageDraw.Draw(template)  # drawing object

# Coordinates of the corners of the box in the template
y1, y2 = 187, 440
x1, x2 = 63, 1045

# Height and width of the box calculated from the coordinates
box_width =  x2 - x1
box_height = y2 - y1


# Text to be printed
cert_text = "Python is an interpreted high-level general-purpose programming language. Its design philosophy. Python is an interpreted high-level general-purpose programming language. Its design"


# Calculating average character width and the number of characters that can be fitter inside the box in one line
text_width, text_height = draw.textsize(cert_text, font=print_font)


per_char_avg_with = text_width // len(cert_text)
size_of_containment = (box_width - (box_width / 5)) // per_char_avg_with

wrapped_text = textwrap.fill(cert_text, width=size_of_containment)
number_lines = len(wrapped_text.split('\n'))

current_line_hight = number_lines * text_height


print(box_height)
print(current_line_hight)

if (current_line_hight - text_height > box_height):
    print("Over the box") 




#line_width, line_height = draw.textsize(wrapped_text[0])


#tw, th = draw.textsize(wrapped_text, font = print_font)
#(tw /2) (th /2)

draw.text((x1 + (box_width / 2), y1 + (box_height / 2)), wrapped_text, font=print_font, fill=(255, 0, 0, 255), anchor = 'mm')


im.save('test.png')
