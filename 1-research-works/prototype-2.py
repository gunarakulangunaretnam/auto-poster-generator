import textwrap
from PIL import ImageFont, ImageDraw, Image
import os


"""Explanation: I found out the width of a single character in the DroidSansMono font (char_width). Since this is a 
monospace font, we won't have to worry about our calculations going wrong because of varying character widths. Then I 
calculated how many such characters can be fitted inside our textbox (char_number). Then wrapped the paragraph using
textwrap.wrap(). Here, the char_number variable was give as the width. PIL.ImageDraw.multiline_text() was used to print
the wrapped text. However, this method only accepts one single string. So all the elements in the list provided by
textwrap.wrap() were concatenated and a \n was added between them. So in the end, one single string, which was properly
formatted as a paragraph was stored in a variable, and got printed. Also, anchor was set to the middle of the paragraph
to make the text centered in the xy coordinates given by us."""


print_font = ImageFont.truetype(font='DroidSansMono.ttf', size=18)
im = template = Image.open(os.path.join(os.getcwd(), "template.png"))  # Read
draw = ImageDraw.Draw(template)  # drawing object

# Coordinates of the corners of the box in the template
y1, y2 = 187, 440
x1, x2 = 63, 1045

# Height and width of the box calculated from the coordinates
box_width = x2 - x1
box_height = y2 - y1

# Properties of a single character in the font (monospace fonts are best for this purpose)
char_width, char_height = draw.textsize('a', font=print_font)

# Suitable number of characters that can be fitter within the box
char_number = box_width // char_width

# Text to be printed
cert_text = "Python is an interpreted high-level general-purpose programming language. Its design philosophy " \
            "emphasizes code readability with its use of significant indentation. Its language constructs as well as " \
            "its object-oriented approach aim to help programmers write clear, logical code for small and large-scale" \
            "projects. "


wrapped_text = textwrap.wrap(cert_text, char_number - 5)
#line_width, line_height = draw.textsize(wrapped_text[0])

# Concatenating strings to convert the wrapped text into one single sentence.
# Because draw.multiline_text can be used for this purpose.

formatted_sentence = ""

for index, phrase in enumerate(wrapped_text):
    formatted_sentence = formatted_sentence + phrase + "\n"

draw.multiline_text((x1 + (box_width / 2), y1 + (box_height / 2)),formatted_sentence,font=print_font,fill=(255, 0, 0, 255))

im.save('test.png')
