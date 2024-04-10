# Como usar HTML básico

## O que é?

HTML é um acrônimo para *Hyper Text Markup Language*, e a linguagem padrão de markup para Websites. Devido a sua
funcionalidade, maleabilidade (ele tem mais opções para serem exploradas, como veremos), é possível a inserção de
trechos de HTML escritos no Markup do GitHub, como imagens, links, contâineres *"`<div>` s"*.

## Sintaxe

HTML funciona em pedaços de instrução, denominados *elementos*. Geralmente eles começam com `<>` e terminam
com `</>`, como por exemplo:

- `<p> conteúdo</p>`
- `<h1>conteúdo</h1>`
- `<h2>conteúdo</h2>`

Temos tambêm tags que fecham automaticamente, como:

- `<img src="" target="_blank">`

Não se preocupe com o significado de cada tag. Vou detalhar tudo.

## Elementos úteis

### Headers

Os headers são títulos. Tem a mesma equivalêncas das `#`, tanto que ao tipar
um header, o git vai mostrar no conteúdo das páginas uma refrência local (que é clicada e o navegador
bota exatamente em cima dela). Os Headers vão de 1 a 6, e tem a seguinte lógica:

- `<h1>Titulo vai aqui</h1>`
- `<h2>Sub-titulo vai aqui</h2>`
- `<h3>Outro sub-titulo aqui</h3>`
- `...`
- `<h6> Até o sexto subtítulo</h6>`

### Imagens

A tag de imagem é única, o que significa que ela não abre nem fecha, só é citada. A tag é:

`<img>`

Os atributos que se atribuem a ela são, em resumo:

- `src`: Link da imagem (pode-se fazer o upload ao git arrastando a imagem ao editor de MD, copiando o link
  fornecido, e inserindo-o aqui)
- `alt` descrição da imagem, aparece ao deixar o cursor sobre, ou simplesmente quando ela não carrega
- `width` comprimento da imagem
- `height` altura da imagem

Para width e height as medidas se dão em pixeis, mas pode-se especificar uma porcentagem colocando %, como
`width="50%"`, o que levaria para uma imagem com metade do comprimento. Existe o atributo auto, então se for
preferível manter a proporção de uma imagem, é possível mudar uma dimensão e deixar a outra se ajustar
automaticamente: `width="100" height=auto`. Exemplo de tag:

`<img src="https://user-images.githubusercontent.com/78660963/175105799-e7865b11-05af-4b2c-8850-80c7f34d4f36.png"
alt="Logo da org do LDTT no GitHub" width="400" height=auto>`

resultado:

![image](https://user-images.githubusercontent.com/78660963/175105799-e7865b11-05af-4b2c-8850-80c7f34d4f36.png)
alt="Logo da org do LDTT no GitHub" width="200" height=auto>

### Links

Para inserir links em HTML usamos a tag `<a></a>`. A idéia é configurar o link com coisas como onde abrir (nova aba
ou a mesma), qual o link. A sintaxe é a que segue:

```HTML
<a href="link vai aqui" target="_blank">Descrição do link</a>
```

O elemento Target especifica onde a janela irá abrir. Para simplificar, digite "_blank" para abrir outra aba (se for
um link que leva para outra página por exemplo), e não digite o elemento `target` para ficar na mesma aba ao clicar.

É possível também transformar outras tags em link, como um Header ou imagem. Basta colocar na "descrição do link" o
elemento que deseja-se usar como link:

```HTML
<a href="link vai aqui" target="_blank"><h1>LINK EM TITULO</h1></a>
<a href="link vai aqui" target="_blank"><img src="link" alt="Agora quando clicar na imagem abre o link" width="400" height=auto></a>
```

### Comentários  

Comentários são trechos de texto que não serão mostrados no editor, como anotações fantasma. Geralmente são
adicionadas como instruções ou explicações do que está sendo feito como o que está sendo feito, ou problemas a serem resolvidos. Para abrir um comentário escreva: `<!-- e para fechar o comentário escreva -->`.

<!--Aqui tem um comentário! HAHA Vc  achou. Agora volta pra janela normal porfa =)-->

### Quotes

Para ler mais sobre citações, seria ideal ler a [página do W3Schools](https://www.w3schools.com/html/html_quotation_elements.asp)
pois possui algumas nuances, e lá existe um editor de HTML para brincar. No entanto abaixo segue um exemplo de citação e como fica renderizado:

```HTML
<blockquote cite="https://www.w3schools.com/html/default.asp">
  HTML is the standard markup language for Web pages.

  With HTML you can create your own Website.

  HTML is easy to learn - You will enjoy it!
</blockquote>
```

Resultado:

<blockquote cite="https://www.w3schools.com/html/default.asp">
  HTML is the standard markup language for Web pages.

With HTML you can create your own Website.

HTML is easy to learn - You will enjoy it!
</blockquote>

### Listas  

Listas devem ser abertas e fechadas, e existem 2 tipos OL *(Ordered Lists)*, `<ol></ol>`, onde os itens serão contados com  números, e UL *(Unordered Lists)*, `<ul></ul>`, que tem os itens marcados por pontos. Cada item deverá ser inicializado e finalizado com uma tag `<li>item</li>`. Exemplo de uma lista:

```HTML
<h6>Lista mercado:<h6>
<ul>
<li>🍌 banana</li>
<li>☕ Café</li>
<li>🚬 cigarrinho</li>
</ul>
```

### Tabela  

Assim como citações, é preferível que seja lido como utilizar [pela página do W3Schools](https://www.w3schools.com/html/html_tables.asp)

Segue aqui um exemplo de cógigo e como ele renderiza:

```HTML
<table>
  <tr>
    <th>Company</th>
    <th>Contact</th>
    <th>Country</th>
  </tr>
  <tr>
    <td>Alfreds Futterkiste</td>
    <td>Maria Anders</td>
    <td>Germany</td>
  </tr>
  <tr>
    <td>Centro comercial Moctezuma</td>
    <td>Francisco Chang</td>
    <td>Mexico</td>
  </tr>
</table>
```

<table>
  <tr>
    <th>Company</th>
    <th>Contact</th>
    <th>Country</th>
  </tr>
  <tr>
    <td>Alfreds Futterkiste</td>
    <td>Maria Anders</td>
    <td>Germany</td>
  </tr>
  <tr>
    <td>Centro comercial Moctezuma</td>
    <td>Francisco Chang</td>
    <td>Mexico</td>
  </tr>
</table>

### Divs  

Divs denominam uma sessão de texto do HTML, por possuir muitos atributos de como configurar, vou citar 2 páginas
para leitura:

- [O que é um div no html, pela W3Schools](https://www.w3schools.com/tags/tag_div.asp)
- [Os diversos atributos do div](https://www.w3schools.com/tags/ref_eventattributes.asp)

No entanto, o propósito da citação dele é que é por ele que é possível centralizar elementos. é utilizado a [tag align](https://www.geeksforgeeks.org/html-div-align-attribute/)
, com a configuração "center". Da seguinte forma:

`<div align="center"></div>`

Vou colocar um texto alinhado para demonstrar:

```HTML
<div align="center">
<p>Olha só</p>
</div>
```

Renderiza:
<div align="center">
<p>Olha só</p>
</div>

Extremamente útil para posicionamento de imagens.