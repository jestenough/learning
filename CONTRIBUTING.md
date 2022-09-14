# Contribution Guidelines

## What should I know before I get started?

Сheck out the [structure](README.md##Structure).
All filenames must:
* Start with a small letter
* Stylized as snake_case


#### Terms

***Subject*** - the name that is the theme of the links (e.g. math, astrobiology, cookery, etc.)
***Part*** - the name that is the type of resources that a links point to (articles, videos, books, catalogs, etc.)


#### Examples

- Links
`- [Link name](link) - Description`
`* [Link name](link) - Description`

- Parts
`## Part name`


## How Can I Contribute?

#### **Do you want to update the materials of an existing subject?**

* **If the part exists**, look at how the previous links are designed, and just do it in the same form (check ***links example***).
* **If the part doesn't exists**, skip two (2) empty lines from the last part (or the name of the subject, if there are no parts), then create the name of the part according to the ***parts example***, skip one line and add links


#### **Do you want to update the materials of a non-existing subject?**

Check which section (materials, art, science) your theme includes, you can do this with links:
- [Outline of formal science](https://en.wikipedia.org/wiki/Outline_of_formal_science)
- [Outline of social science](https://en.wikipedia.org/wiki/Outline_of_social_science)
- [Outline of natural science](https://en.wikipedia.org/wiki/Outline_of_natural_science)
- [Outline of performing arts](https://en.wikipedia.org/wiki/Outline_of_performing_arts)
- [Outline of visual arts](https://en.wikipedia.org/wiki/Outline_of_the_visual_arts)

> If links are not useful, then you will have to act according to logic, for example, you will not put botany in pedagogy (As a last resort, you can ask via **issue**)

Having decided on the section, understand whether your subject is independent or is part of another subject to which the subject belongs, create for it:
* a **folder** if it has possible subtopics in the future:
`SubjectName/SubjectName.md`
* a **file** if no subtopics are planned
`subjectName.md`

> :warning: Do not forget to add an entry about the new topic to the [SUMMARY.md](learn/SUMMARY.md) file, specifying the name of the topic and the path to it `.md` file.
> put `* [SubjectName](pathToSubject)` if you add a **file**
> put `- [SubjectName](pathToSubject)` if you add a **folder**

Open the `.md` file of the element that you just created, make its beginning according to the template:

```markdown
# Description

`Add description (1-2 sentences)` - it is not necessary, you can just leave `TODO`
```

Next, add **part** and links in accordance with the requirements described in `update existing subject ` header
