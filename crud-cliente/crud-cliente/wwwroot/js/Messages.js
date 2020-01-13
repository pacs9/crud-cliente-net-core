function confirmaDelecao(url) {
    bootbox.confirm({
        message: 'Deseja excluir o registro selecionado?',
        callback: function (confirmacao) {            
            if (confirmacao)
            {
                var form = document.createElement("form");
                form.action = url;
                form.method = "POST";                

                $(form).append($('input[name="__RequestVerificationToken"]'));                

                $('body').append(form);

                $(form).submit();
            }            
        },
        buttons: {
            cancel: { label: 'Cancelar', className: 'btn-default' },
            confirm: { label: 'Excluir', className: 'btn-danger' }

        }
    });
}