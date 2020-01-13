function alertMessage(type, message) {

    // create the notification
    var notification = new NotificationFx({
        message: message,
        layout: 'growl',
        effect: 'jelly',
        //type: success, notice, warning or error
        type: type,
        ttl: 1000,
    });

    // show the notification
    notification.show();
};

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

function confirmaEstorno(url) {
    bootbox.confirm({
        message: 'Deseja estornar o registro selecionado?',
        callback: function (confirmacao) {
            if (confirmacao) {
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
            confirm: { label: 'Estornar', className: 'btn-danger' }

        }
    });
}


function menssagemConfirmacao(title, msg) {
    return bootbox.dialog({
        title: title,
        message: msg,
        onEscape: true,       //HERE
        buttons: {
            cancel: {
                label: 'Não',
                className: 'btn-default'
            },
            confirm: {
                label: 'Sim',
                className: 'btn-warning'
            }
        }
    });
}

function handleAjaxMessages() {
    $(document).ajaxSuccess(function (event, request) {
        checkAndHandleMessageFromHeader(request);
    }).ajaxError(function (event, request) {

        if (request.statusText !== 'abort') {
            displayMessage("Erro na conexão com o servidor!", "alert-danger");
            //$('.page-spinner-bar').hide();
        }
    });

}

function checkAndHandleMessageFromHeader(request) {

    var msg = request.getResponseHeader('X-Message');
    if (msg) {
        displayMessage(msg, request.getResponseHeader('X-Message-Type'));
    }
}

function displayMessage(message, messageType) {
    
    $(".box-msg div").addClass(messageType);

    $(".b-mensagem").text(message);

    $(".alert-dismissible").fadeTo(3000, 500).slideUp(500, function () {
        $(".alert-dismissible").slideUp(500);
        $(".box-msg div").removeClass(messageType);        
    });
}

$(document).ready(function () {
    handleAjaxMessages();
})