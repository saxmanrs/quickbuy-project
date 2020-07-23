using System;

public class FormaPagamento
{
    public int IdPagamento { get; set; }
    public string Nome_Pagamento { get; set; }
    public string Descricao_pagamento { get; set; }


    public bool EhBoleto
    {
        get { return IdPagamento == (int)TipoPagamento.Boleto; }

    }
    public bool EhDeposito
    {
        get { return IdPagamento == (int)TipoPagamento.Deposito; }

    }
    public bool EhDinheiro
    {
        get { return IdPagamento == (int)TipoPagamento.Dinheiro; }

    }
    public bool EhNaodefinido
    {
        get { return IdPagamento == (int)TipoPagamento.Naodefinido; }

    }



}
