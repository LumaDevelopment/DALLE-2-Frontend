# DALLE·2 Frontend
## Background
A couple of my friends have recently gotten into AI art generation, and I recommended DALLE·2 to them. While I was poking around the consumer pricing and developer documentation, something caught my eye. For the Open AI hosted frontend, I noticed a credit was $0.13. Each credit generates 4 910x910 images. In requested by the API, an individual 910x910 image is $0.02, so 4 of them are collectively $0.08. Of course, I found this entirely reasonable frontend tax outrageous, and decided to build my own for those sweet, sweet cost savings like any other reasonable developer.

<img src="./dalle2frontend.gif">

## Functionality
- Define a prompt, image resolution, and number of pictures to generate.
- Review request cost.
- Make image generation requests with DALLE·2.
- Preview images in a gallery.
- Save images.

## Restrictions
DALLE·2 Frontend doesn't utilize some of DALLE·2's other capabilities, such as image edits and variations. Perhaps at some point in the future?
