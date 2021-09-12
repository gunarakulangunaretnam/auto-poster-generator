import textwrap
from PIL import ImageFont, ImageDraw, Image
import os


use_font = './times.ttf'
use_size = 34
use_spacing = 4  # Default spacing between lines for Imagedraw.multilline_text()


print_font = ImageFont.truetype(font=use_font, size=use_size)
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

# Copied block start
# Calculating average character width and the number of characters that can be fitter inside the box in one line
text_width, text_height = draw.textsize(cert_text, font=(ImageFont.truetype(font=use_font, size=use_size)))
char_width = text_width // len(cert_text)
char_number = (box_width - (box_width / 10)) // char_width
print(text_width, len(cert_text), char_number)

wrapped_text = textwrap.fill(cert_text, width=char_number)
line_width, line_height = draw.textsize(wrapped_text[0])
print(wrapped_text)

# Reducing font size if needed
temp_wrapped_text = textwrap.fill(cert_text, width=char_number)
line_widths = []
line_heights = []

for phrase in temp_wrapped_text.split('\n'):
    line_heights.append((draw.textsize(phrase, font=(ImageFont.truetype(font=use_font, size=use_size))))[1])

total_line_height = sum(line_heights) + (use_spacing * len(line_heights))
print("Box height: ", box_height)
print("Line height details: ", sum(line_heights), (use_spacing * len(line_heights)))
# Copied block end


while box_height < total_line_height:

    use_size = int(input(f"Font size {use_size} too big. Try a reduced font size: "))
    line_heights.clear()

# Repetition starts here
    # Calculating average character width and the number of characters that can be fitter inside the box in one line
    text_width, text_height = draw.textsize(cert_text, font=(ImageFont.truetype(font=use_font, size=use_size)))
    char_width = text_width // len(cert_text)
    char_number = (box_width - (box_width / 10)) // char_width
    print(text_width, len(cert_text), char_number)

    wrapped_text = textwrap.fill(cert_text, width=char_number)
    line_width, line_height = draw.textsize(wrapped_text[0])
    print(wrapped_text)

    # Reducing font size if needed
    temp_wrapped_text = textwrap.fill(cert_text, width=char_number)
    line_widths = []
    line_heights = []

    for phrase in temp_wrapped_text.split('\n'):
        line_heights.append((draw.textsize(phrase, font=(ImageFont.truetype(font=use_font, size=use_size))))[1])

    total_line_height = sum(line_heights) + (use_spacing * len(line_heights))
    print("Box height: ", box_height)
    print("Line height details: ", sum(line_heights), (use_spacing * len(line_heights)))
# Repetition ends here

draw.multiline_text((x1 + (box_width / 2), y1 + (box_height / 2)),
                    wrapped_text,
                    font=ImageFont.truetype(font=use_font, size=use_size),
                    fill=(255, 0, 0, 255),
                    anchor='mm',
                    spacing=use_spacing)

print()
im.save('test.png')
