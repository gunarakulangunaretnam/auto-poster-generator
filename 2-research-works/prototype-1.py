from PIL import Image, ImageDraw, ImageFont # Load pillow
import os # Load os
from textwrap3 import wrap
import textwrap

font = ImageFont.truetype('arial.ttf', 60) #Font
im = template = Image.open(os.path.join(os.getcwd(),"template.png")) #Read
draw = ImageDraw.Draw(im) #drawing object

#Title box
iw = 1280
ih = 720

y1 = 187
y2 = 440

x1 = 63
x2 = 1045

boxWidth = x2 - x1
boxHight = y2 - y1 

text = "The quote isn’t fitting inside my box. I will need some line breaks between the words. The below code does the trick for me."

char_width, char_height = draw.textsize(text, font=font)

per_char_with = char_width / len(text)

per_line = (boxWidth) / per_char_with

print(per_line)


text = textwrap.fill(text=text, width=per_line)

tw, th = draw.textsize(text, font = font)


draw.text(((boxWidth / 2) - (tw /2) + x1 , (boxHight / 2) - (th / 2) + y1), str(text), align="center", font=font, fill=(255,0,0,255))

#Heading Box
sy1 = 97
sy2 = 171

sx1 = 352
sx2 = 754

s_boxWidth = sx2 - sx1
s_boxHight = sy2 - sy1 

s_text = "English"
text = textwrap.fill(text=text, width=60)
stw, sth = draw.textsize(s_text, font = font)


draw.text(((s_boxWidth / 2) - (stw /2) + sx1 , (s_boxHight / 2) - (sth / 2) + sy1), str(s_text), align="center", font=font,  fill=(255,0,0,255))

im.save('test.png')