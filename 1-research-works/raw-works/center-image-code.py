from PIL import Image, ImageDraw, ImageFont
import textwrap
import os

font = ImageFont.truetype('arial.ttf', 18)
im = template = Image.open(os.path.join(os.getcwd(),"template.png"))
draw = ImageDraw.Draw(im)

y2 = 170
y1 = 95

x2 = 753
x1 = 353

boxH = y2 - y1
boxW = x2 - x1

w, h = draw.textsize("Hello, Gunarakulan, How are you")
draw.text(((x2 - (boxW / 2)-w), (y2 - (boxH / 2))-h), "Hello, Gunarakulan, How are you", font=font, fill=(255,0,0,255))
im.save('test.png')