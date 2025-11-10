# This is Heading 1
## And this is Heading 2
### Heading 3 looks like this
Normal text looks like this. An empty line creates a new paragraph with the default spacing of 16px. 

Two empty lines create a section break with the default spacing of 32px. 

 
**Single line breaks** 
are kept, but don't create new paragraphs.

Some elements, such as block quotes and code blocks, create automatic section breaks. And headings can have custom spacing for each level.

> #### THIS IS HEADING 4
> 
> Block quotes look like this. They have their own font size but can contain any layout elements, such as:
> - Bullet lists,
> - **Bold** and *italic* text, etc...

```
This is a code block. It can only contain text and not layout elements.
```

---
::spacer 8

Spacers can be used to control the space between elements, if the defaults don't look correct. The horizontal line above has exactly 8px below it.

> You can specify size and alignment for images. Spacers, even negative ones, can be used to control vertical placement.

![](https://www.svgrepo.com/show/530402/honor.svg){ alignment=Start width=40 height=40}
::spacer -40
![](https://www.svgrepo.com/show/530402/honor.svg){ alignment=End width=40 height=40}
