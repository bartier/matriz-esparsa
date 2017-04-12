Matriz Esparsa
================

**Projeto apresentado na matéria de Estrutura de Dados no curso técnico do COTUCA. Desenvolvido com C#.**


## O que é matriz esparsa?

![1](https://cloud.githubusercontent.com/assets/18057391/24839313/2254599c-1d2e-11e7-8924-7cd498f26e48.png)

Uma matriz é dita esparsa quando possui uma grande quantidade de elementos que valem zero (ou não presentes, ou não necessários).

## Como é implementada?
Em conjunto com células cabeça, a matriz esparsa é implementada através de um conjunto de listas ligadas que apontam para células com valores diferentes de 0.

A matriz esparsa portanto terá uma **cabecaPrincipal** que será a primeira célula tanto da lista circular das linhas, quanto da lista circular das colunas.

Visualmente a **matriz esparsa** poderia ser representada assim:
![2](https://cloud.githubusercontent.com/assets/18057391/24839320/33819c2a-1d2e-11e7-9a61-43061b48186a.png)


As **células** das matrizes portando guardam:
- célula da direita;
- célula debaixo;
- coordenadas próprias (linha,coluna);
- valor (diferente de 0 ou null para células cabeça).

Visualmente a **célula** poderia ser representada assim:

![3](https://cloud.githubusercontent.com/assets/18057391/24839325/3d3552b6-1d2e-11e7-8f25-97554e2f8692.png)

---

**Da proposta do projeto:**  

O programa deve ter as seguintes operações:

- [x] Criar a estrutura básica da matriz esparsa com dimensão M x N
- [x] Inserir um novo elemento em uma posição (l, c) da matriz
- [x] Ler um arquivo texto com as coordenadas e os valores não nulos, armazenando-os na matriz
- [x] Retornar o valor de uma posição (l, c) da matriz
- [x] Exibir a matriz na tela, em um gridView
- [x] Liberar todas as posições alocadas da matriz, incluindo sua estrutura básica
- [x] Remover o elemento (l,c) da matriz
- [x] Somar a constante K a todos os elementos da coluna C da matriz
- [x] Somar duas matrizes esparsas, cada uma representada em uma estrutura própria e ambas exibidas
em seu próprio gridView. O resultado deve gerar uma nova estrutura de matriz esparsa e exibido
em um gridview próprio
- [x] Multiplicar duas matrizes esparsas, cada uma representada em uma estrutura própria e ambas
exibidas em seu próprio gridView.

---

##### Referências

[**Matriz Esparsa - Wikipedia.**](https://pt.wikipedia.org/wiki/Matriz_esparsa)   
[**Slides UNICAMP.**](http://www.lis.ic.unicamp.br/~mc102/files/mesparsa.pdf)
