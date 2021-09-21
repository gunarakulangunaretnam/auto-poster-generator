import textwrap
from PIL import ImageFont, ImageDraw, Image
import os


print_font = ImageFont.truetype(font='./times.ttf', size=35)
im = template = Image.open(os.path.join(os.getcwd(), "template.png"))  # Read
draw = ImageDraw.Draw(template)  # drawing object

# Coordinates of the corners of the box in the template
y1, y2 = 187, 440
x1, x2 = 63, 1045

# Height and width of the box calculated from the coordinates
box_width = x2 - x1
box_height = y2 - y1


# Text to be printed
cert_text = "Python is an interpreted high-level general-purpose programming language. Its design philosophy " \
            "emphasizes code readability with its use of significant indentation. Its language constructs as well as " \
            "its object-oriented approach aim to help programmers write clear, logical code for small and large-scale" \
            "projects. "

# Calculating average character width and the number of characters that can be fitter inside the box in one line
text_width,  text_height = draw.textsize(cert_text, font=print_font)
char_width = text_width // len(cert_text)
char_number = (box_width - (box_width / 10)) // char_width
print(text_width, len(cert_text), char_number)


wrapped_text = textwrap.fill(cert_text, width=char_number)
line_width, line_height = draw.textsize(wrapped_text[0])
print(wrapped_text)

draw.multiline_text((x1 + (box_width / 2), y1 + (box_height / 2)),
                    wrapped_text,
                    font=print_font,
                    fill=(255, 0, 0, 255),
                    anchor='mm')

print()
im.save('test.png')
