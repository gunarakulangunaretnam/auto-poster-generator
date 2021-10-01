from PIL import Image, ImageDraw, ImageFont # Load pillow
import os # Load os
from textwrap3 import wrap
import textwrap

text = '''The rain in Spain falls mainly on the plains.'''
text = textwrap.fill(text=text, width=80)

y1 = 187
y2 = 440

x1 = 63
x2 = 1045

boxWidth = x2 - x1
boxHight = y2 - y1 
im = template = Image.open(os.path.join(os.getcwd(),"template.png")) #Read
draw = ImageDraw.Draw(im)
font = ImageFont.truetype('arial.ttf', 25) #Font

current_h, pad = boxHight, boxHight
for line in text:
    tw, th = draw.textsize(line, font = font)
    draw.text(((boxWidth / 2) - (tw /2) + x1 , (boxHight / 2) - (th / 2) + y1), str(text), line, fontcolor=(255,0,0,255), font=font)
    current_h += th + pad

im.save('test.png')