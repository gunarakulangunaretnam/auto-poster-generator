import textwrap
from PIL import ImageFont, ImageDraw, Image
import os


template = Image.open(os.path.join(os.getcwd(), "template.png"))  # Read
draw = ImageDraw.Draw(template)  # drawing object

use_font = './times.ttf'
use_size = 24
cert_text = "Python is an interpreted high-level general-purpose programming language. Its design philosophy " \
            "emphasizes code readability with its use of significant indentation. Its language constructs as well as " \
            "its object-oriented approach aim to help programmers write clear, logical code for small and large-scale" \
            "projects. "

# Coordinates of the corners of the box in the template
y1, y2 = 187, 440
x1, x2 = 63, 1045

# Height and width of the box calculated from the coordinates
box_width = x2 - x1
box_height = y2 - y1


def fit_char(container_width=box_width, text=cert_text, font=use_font, font_size=use_size) -> int:
    print_font = ImageFont.truetype(font=font, size=font_size)
    text_width, text_height = draw.textsize(text, font=print_font)
    avg_char_width = text_width // len(text)
    char_number = (container_width - (container_width / 10)) // avg_char_width
    return char_number


def check_fit(chars=fit_char(), text=cert_text, font=use_font) -> bool:
    print_font = ImageFont.truetype(font=font, size=use_size)
    wrapped_text = textwrap.fill(text, width=chars)
    line_widths = []
    line_heights = []

    for phrase in wrapped_text.split('\n'):
        line_widths.append((draw.textsize(phrase, font=print_font))[0])
        line_heights.append((draw.textsize(phrase, font=print_font))[1])

    max_line_width = max(line_widths)
    max_line_height = max(line_heights)

    return chars >= (max_line_width // chars)


char_num = fit_char()

print(check_fit())


