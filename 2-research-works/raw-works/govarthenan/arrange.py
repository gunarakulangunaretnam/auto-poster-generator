import textwrap
from PIL import ImageFont, ImageDraw, Image
import os

im = template = Image.open(os.path.join(os.getcwd(), "template.png"))  # Read
draw = ImageDraw.Draw(template)  # drawing object

use_font = './times.ttf'
use_size = 40
prev_size = use_size
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


def char_width(font=use_font, font_size=use_size) -> int:
    """Calculates the average character width using the given font calculation."""
    print_font = ImageFont.truetype(font=font, size=font_size)
    text_width, text_height = draw.textsize(cert_text, font=print_font)
    avg_char_width = text_width // len(cert_text)
    return avg_char_width


def fit_char(span=box_width) -> int:
    """Calculates how many characters can be fitted inside the given container."""
    char_number = (span - (span // 10)) // char_width()
    return char_number


def wrap(text=cert_text) -> str:
    """Wraps the given text using '\n' to fit the desired width."""
    wrapped_text = textwrap.fill(text, fit_char())
    return wrapped_text


def check_height(wrapped_text=wrap(), font=use_font, font_size=use_size) -> bool:
    """Checks whether the lines in the wrapped text exceed the given container configuration."""
    print_font = ImageFont.truetype(font=font, size=font_size)
    print(f"checking fit using font size {use_size}")
    line_widths = []
    line_heights = []

    for phrase in wrapped_text.split('\n'):
        line_widths.append((draw.textsize(phrase, font=print_font))[0])
        line_heights.append((draw.textsize(phrase, font=print_font))[1])

    max_line_width = max(line_widths)
    total_line_height = sum(line_heights) + 4 * len(line_heights)
    print(f"Line heights = {line_heights}")
    print(f"Total line heights = {sum(line_heights) + 4 * len(line_heights)}")

    if total_line_height > box_height:
        return True
    else:
        return False


while check_height():
    print("Font size is too big.")

    if input("Would you like to lower the font size automatically? (y/n): ").lower().strip() == 'y':
        print("Trying font size", use_size - 1)
        use_size -= 1
        temp_font = ImageFont.truetype(font=use_font, size=use_size)
        temp_wrapped_text = wrap()
    else:
        use_size = int(round(float(input(f"Enter a font size smaller than {use_size}: "))))
        print("Trying font size", use_size - 1)
        use_size -= 1
        temp_font = ImageFont.truetype(font=use_font, size=use_size)
        temp_wrapped_text = wrap()

final_font = ImageFont.truetype(font='./times.ttf', size=use_size)
print(wrap())
print((x1 + box_width // 2, y1 + box_height // 2))

draw.multiline_text(xy=(x1 + box_width // 2, y1 + box_height // 2),
                    text=wrap(cert_text),
                    font=final_font,
                    anchor='mm')

template.save('test.png')
