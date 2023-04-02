let elementSweetAlert = document.getElementById('sweet-alert').value;
if (elementSweetAlert !== "") {
    let modelSweetAlert = JSON.parse(elementSweetAlert)
    if (Boolean(modelSweetAlert.Show)) {
        swal({
            title: modelSweetAlert.Title,
            text: modelSweetAlert.Text,
            icon: modelSweetAlert.Icon,
            button: modelSweetAlert.ButtonText
        }).then((result) => {
            if (modelSweetAlert.ActionPageRedirect !== "") {
                window.location.href = modelSweetAlert.ActionPageRedirect;
            }
        });
    }
}
