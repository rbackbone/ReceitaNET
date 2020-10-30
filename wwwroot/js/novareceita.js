class ClAjax {

    clickMais(btn) {

        let itemReceita = this.getData(btn);
        itemReceita.Quantidade++;
        this.postQuantidade(itemReceita);
        debugger;
    }

    clickMenos(btn) {

        let itemReceita = this.getData(btn);
        itemReceita.Quantidade--;
        this.postQuantidade(itemReceita);
        debugger;
    }

    updateQuantidade(input) {

        let itemReceita = this.getData(input);
        this.postQuantidade(itemReceita);
        debugger;
    }


    getData(elemento) {
        var linhaItem = $(elemento).parents('[insumo-id]');
        var insumoId = $(linhaItem).attr('insumo-id');
        var receitaId = $(linhaItem).attr('receita-id');
        var novaQtd = $(linhaItem).find('input').val();

        return {
            InsumoId: insumoId,
            ReceitaId: receitaId,
            Quantidade: novaQtd
        };

    }

    postQuantidade(itemReceita) {

        $.ajax({
            url: '/receita/alteraquantidade',
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            data: JSON.stringify(itemReceita),
            dataType: "json",
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        }).done(function (response) {

            let itemReceita = response.itemReceita;
            let linhaDoItem = $('[insumo-id=' + itemReceita.insumoId + ']');
            linhaDoItem.find('input').val(itemReceita.quantidade);

            if (itemReceita.quantidade == 0) {
                linhaDoItem.remove();
            }

            debugger;

        });

    }
}

var novaReceita = new ClAjax();