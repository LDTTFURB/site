## Como fazer referências (links)?

Existem 2 formas, que estão formalmente documentadas em:

- [sintaxe de markup](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax#links)
- [sintaxe de HTML](https://www.w3schools.com/html/html_links.asp)

## E como fazer da wiki para um repositório local?

Seria especialmente bom dar uma
lida [na sintaxe de links relativos do git](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax#relative-links)
. As wikis se comportam como uma pasta do repositório (/wiki/...), então dentro da referenciação temos algo como:

    /../../repositório

E a partir daí é só tipar a localização do trecho de código necessário.

[Exemplo real](https://github.com/ADalmolin3103/javax/wiki). 

Repare que no modo prévia o link pode aparecer quebrado, é necessário fazer o commit (salvar) a página. Código fonte do exemplo acima:

<img src="https://user-images.githubusercontent.com/78660963/174890661-f6e7915b-c184-4648-b645-2c85a680b3d6.png" alt="imagem do código fonte" target="_blank" width="500" heigh=auto>

