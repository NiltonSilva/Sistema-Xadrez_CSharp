﻿using tabuleiro;
using xadrez_console;
using xadrez;

//try
//{
//    Tabuleiro tab = new Tabuleiro(8, 8);

//    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
//    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
//    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

//    Tela.ImprimirTabuleiro(tab);
//    Console.WriteLine();
//}
//catch (TabuleiroException e)
//{
//    Console.WriteLine(e.Message);
//}


PosicaoXadrez pos = new PosicaoXadrez('c', 7);
Console.WriteLine(pos);

Console.WriteLine(pos.toPosicao());
Console.ReadLine();