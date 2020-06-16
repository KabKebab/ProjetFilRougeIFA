$(function () {
    $('#tableauResultat').load('/Utilisateur/TableauUtilisateur');
   
    
});

$('#TableauCompetences').load('/Competence/TableauCompetences');


$("#tomme").click(function () {
    $("#result").load("Utilisateur/index", function () {
        alert("Page.html has been loaded successfully!")
    });
});

//function idincruste() {
//    function () {

//        var data = JSON.stringify(GetUser());

//        $.ajax({
//            type: 'POST',
//            url: '@Url.Action("EnregistreEdit", "Utilisateur")',
//            contentType: "application/json;",
//            data: data,
//            success: function (response) {



//            },
//            error: function (response) {



//            }
//        });
//    }

//        $('.modal').modal('hide');
//        setTimeout(() => { Close() }, 500);
//    }

   


function Close() {
    $('#tableauResultat').load('/Utilisateur/TableauUtilisateur'); 
    
}


function GetUser123() {



    var jsonObject = {

        "nom": $("#Insertnom").val(),
        "prenom": $("#Insertprenom").val(),
        "nomDeCompte": $("#InsertnomDeCompte").val(),

        "motDePasse": $("#InsertmotDePasse").val(),
        "id_ROLE": $("#Insertid_ROLE").val(),
    };
    return jsonObject;
}




$("#InsertionUser").click(function () {
    var x = document.getElementById("MenuUtilisateur");
    if (x.style.display === "block") {
        x.style.display = "none";
        console.log("none");
    }
    else {
        x.style.display = "block";
        console.log("block");
    }


});


