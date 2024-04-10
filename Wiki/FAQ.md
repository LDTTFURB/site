# Como fazer referências (links)?

Existem 2 formas, que estão formalmente documentadas em:

- [Sintaxe de markup](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax#links)
- [Sintaxe de HTML](https://www.w3schools.com/html/html_links.asp)

## E como fazer da wiki para um repositório local?

Seria interessante ler a página [sobre sintaxe de links relativos do GitHub](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax#relative-links)
. As wikis se comportam como uma pasta do repositório (/wiki/...), então dentro da referenciação temos algo como:

    /../../repositório

E a partir daí é só tipar a localização do trecho de código necessário.

[Exemplo real](https://github.com/LDTTFURB/site).

Repare que no modo prévia o link pode aparecer quebrado, é necessário fazer o commit (salvar) a página. Código fonte do exemplo acima:  

    [Exemplo real](https://github.com/LDTTFURB/site).
