﻿//Add Produit
function showModelAddProduit() {
  $("#ModelAddProduit").modal("show");
}
function hideModelAddProduit() {
    $("#ModelAddProduit").modal("hide");
}

function AddProduit() {
    class Produit {
        Reference;
        Nom;
        Formule;
        CAS;
        Toxicite;
        EtatPhysique;
        UniteMesure;
        Perissable;
        TempMinStockage;
        TempMaxStockage;
        ConditionStockage;
        TypeGestion;
        StockMin;
        Stock;
        constructor() {
            this.Reference = $("#reference").val();
            this.Nom = $("#nom").val();
            this.Formule = $("#formule").val();
            this.CAS = $("#cas").val();
            this.Toxicite = $("#toxicite").val();
            this.EtatPhysique = $("#etatPhysique").val();
            this.UniteMesure = $("#uniteMesure").val();

            var valeur;
            if (document.getElementById('optionsRadiosInline1').checked) {
                valeur = 1;
            }

            else {
                valeur = 0;
            }
            this.Perissable = valeur;
            this.TempMinStockage = $("#tempMinStockage").val();
            this.TempMaxStockage = $("#tempMaxStockage").val();
            this.ConditionStockage = $("#conditionStockage").val();
            this.TypeGestion = $("#typeGestion").val();
            this.StockMin = $("#stockMin").val();
            this.Stock = $("#stock").val();
        }
    }
    //var p = this.Perissable = $("#perissable").val();
    // alert(p);
    $.validator.unobtrusive.parse($("#form"));
    if ($(form).valid()) {

       /* var uploadFile = $('#files').get(0)
        var files = uploadFile.files; 
        var data = new FormData();
        for (var i = 0; i < files.length; i++) {
            data.append(files[i].name, files[i]);
        }

        var prod = new Produit();

        data.append("Reference", prod.Reference);
        data.append("Nom", prod.Nom);
        data.append("Formule", prod.Formule);
        data.append("CAS", prod.CAS);
        data.append("Toxicite", prod.Toxicite);
        data.append("EtatPhysique", prod.EtatPhysique);
        data.append("UniteMesure", prod.UniteMesure);
        data.append("Perissable", prod.Perissable);
        data.append("TempMinStockage", prod.TempMinStockage);
        data.append("TempMaxStockage", prod.TempMaxStockage);
        data.append("ConditionStockage", prod.ConditionStockage);
        data.append("TypeGestion", prod.TypeGestion);
        data.append("StockMin", prod.StockMin);
        data.append("Stock", prod.Stock);

        $.ajax({
            url: "/Produit/AddProduit",
            type: "POST",
            data: data,
            contentType: false,
            cache: false,
            processData: false,
            success: function (msg) {
                ("ajax successsssssss " + msg.message)
                hideModelAddProduit();
                alertify.success(msg.message);
                setTimeout(function () { location.reload(); }, 1000);
            },
            error: function () {
                alert("error send images")
            }
        });*/

        $.post("/Produit/AddProduit", { Produit: new Produit() }, function (result) {
             if (result.success) {
                 hideModelAddProduit();
                 alertify.success(result.message);
                 setTimeout(function () { location.reload(); }, 1000);
             }
             else {
                 hideModelAddProduit();
                 alertify.error(result.message);
             }
         });
    }
    else {
        return false;
    }
}


//Update Produit

function showModelUpdateProduit(Id) {
    if (Id != null && Id != undefined) {
        $.get("/Produit/GetProduit", { Id: Id }, function (result) {
            $("#upreference").val(result.reference);
            $("#upnom").val(result.nom);
            $("#upformule").val(result.formule);
            $("#upcas").val(result.cas);
            $("#uptoxicite").val(result.toxicite);
            $("#upetatPhysique").val(result.etatPhysique);
            $("#upuniteMesure").val(result.uniteMesure);
            $("#upperissable").val(result.perissable);
            $("#uptempMinStockage").val(result.tempMinStockage);
            $("#uptempMaxStockage").val(result.tempMaxStockage);
            $("#upconditionStockage").val(result.conditionStockage);
            $("#uptypeGestion").val(result.typeGestion);
            $("#upstockMin").val(result.stockMin);
            $("#upstock").val(result.stock);
            sessionStorage.setItem("idProduit", Id);
            $("#ModelUpdateProduit").modal("show");
        })
    }
    else {
        alertify.error("Cannot Show this Produit");
    }
}
function hideModelUpdateProduit() {
    $("#ModelUpdateProduit").modal("hide");
}

function UpdateProduit() {
    class Produit {
        Reference;
        Nom;
        Formule;
        CAS;
        Toxicite;
        EtatPhysique;
        UniteMesure;
        Perissable;
        TempMinStockage;
        TempMaxStockage;
        ConditionStockage;
        TypeGestion;
        StockMin;
        Stock;
        constructor() {
            this.Reference = $("#upreference").val();
            this.Nom = $("#upnom").val();
            this.Formule = $("#upformule").val();
            this.CAS = $("#upcas").val();
            this.Toxicite = $("#uptoxicite").val();
            this.EtatPhysique = $("#upetatPhysique").val();
            this.UniteMesure = $("#upuniteMesure").val();
            var valeur;
            if (document.getElementById('optionsRadiosInline1').checked) {
                valeur = 1;
            }
            else {
                valeur = 0;
            }
            this.Perissable = valeur;
            this.TempMinStockage = $("#uptempMinStockage").val();
            this.TempMaxStockage = $("#uptempMaxStockage").val();
            this.ConditionStockage = $("#upconditionStockage").val();
            this.TypeGestion = $("#uptypeGestion").val();
            this.StockMin = $("#upstockMin").val();
            this.Stock = $("#upstock").val();
        }
    }
    $.validator.unobtrusive.parse($("#upform"));
    if ($(upform).valid()) {
        if (sessionStorage.getItem("idProduit") != 0 && sessionStorage.getItem("idProduit") != undefined) {
            var Id = sessionStorage.getItem("idProduit");
            $.post("/Produit/UpdateProduit", { Id: Id, Produit: new Produit() }, function (result) {
                if (result.success) {
                    hideModelUpdateProduit();
                    alertify.success(result.message);
                    setTimeout(function () { location.reload(); }, 1000);
                }
                else {
                    hideModelUpdateProduit();
                    alertify.error(result.message);
                }
            });
        }
        else {
            alertify.error("Cannot update this Produit");
        }

    }
    else {
        return false;
    }

}

//Delete Produit

function hideModelDeleteProduit() {
    $("#ModalDeleteProduit").modal("hide");
}

function showModelDeleteProduit(Id) {
    sessionStorage.setItem("idProduit", Id);
    $("#ModalDeleteProduit").modal("show");
}

function DeleteProduit() {
    if (sessionStorage.getItem("idProduit") != 0 && sessionStorage.getItem("idProduit") != undefined) {
        var Id = sessionStorage.getItem("idProduit");
        $.post("/Produit/DeleteProduit", { Id: Id }, function (result) {
            if (result.success) {
                hideModelDeleteProduit();
                alertify.success(result.message);
                setTimeout(function () { location.reload(); }, 1000);
            }
            else {
                hideModelDeleteProduit();
                alertify.error(result.message);
            }
        });
    }
    else {
        alertify.error("Cannot delete this Produit");
    }
}


// Recherche Produit

function RechercheProduit() {
    $(document).ready(function () {
        function Contains(text_one, text_two) {
            if (text_one.indexOf(text_two) != -1)
                return true;
        }
        $("#search").keyup(function () {
            var searchText = $("#search").val().toLowerCase();
            $(".search").each(function () {
                if (!Contains($(this).text().toLowerCase(), searchText)) {
                    $(this).hide();
                }
                else {
                    $(this).show();
                }
            });
        });
    });
}

// Details Produit

function hideModelDetailProduit() {
    $("#ModalDetailArticle").modal("hide");
}

function showModelDetailProduit(Id) {
    if (Id != null && Id != undefined) {
        $.get("/Produit/GetProduitAndLot", { Id: Id }, function (result) {
           // alert(result.message.lots);
            $("#referencepl").text(result.message.reference);
            $("#produitpl").text(result.message.nom);
            $("#formulepl").text(result.message.formule);
            $("#caspl").text(result.message.cas);
            var k = 1;
            for (var i in result.message.lots) {
                var Conct = result.message.lots[i].concentration;
                var Puret = result.message.lots[i].purete;
                var datep = result.message.lots[i].datePeremption;
                var Stok = result.message.lots[i].stock;
                //alert(Stok);
                $("#ligne").append("<tr><td>" + Puret + "</td > <td> " + Conct + "</td > <td>" + datep.substr(0,10) + "</td > <td>" + Stok + "</td ></tr > ")
                /*$("#puret").text(Puret);
                $("#con").text(Conct);
                $("#stk").text(Stok);
                $("#dap").text(datep.substr(0, 10));*/

            }
        });
    }
      /*  $.get("/Produit/GetProduit", { Id: Id }, function (result) {
            $("#concentration").text(result.lots.concentration);
            $("#purete").text(result.lots.purete);
            $("#stocklot").text(result.lots.stock);
            $("#datePeremption").text(result.lots.datePeremption.substr(0,10));
            sessionStorage.setItem("idProduit", id);
            $("#ModalDetailLot").modal("show");
        })
    }
    sessionStorage.setItem("idProduit", Id);*/
    $("#ModalDetailArticle").modal("show");
}

function FFermeture() {
    setTimeout(function () { location.reload(); }, 1);
}


/*******************************************************  Gestion Lots ****************************************/

//Add Lots
function showModelAddLott() {
    $("#ModelAddLot").modal("show");
}
function hideModelAddlot() {
    $("#ModelAddLot").modal("hide");
}

function AddLot() {
    class Lot {
        IdProduit;
        Purete;
        Concentration;
        DatePeremption;
        Stock;
        constructor() {
            this.IdProduit = $("#idproduit").val();
            this.Purete = $("#purete").val();
            this.Concentration = $("#concentration").val();
            this.DatePeremption = $("#dateperemtion").val();
            this.Stock = $("#stock").val();
        }
    }
    $.validator.unobtrusive.parse($("#formlot"));
    if ($(formlot).valid()) {

        $.post("/Lot/AddLot", { Lot: new Lot() }, function (result) {
             if (result.success) {
                 hideModelAddlot();
                 alertify.success(result.message);
                 setTimeout(function () { location.reload(); }, 1000);
             }
             else {
                 //hideModelAddlot();
                 alertify.error(result.message);
             }
         });
    }
    else {
        return false;
    }
}

// Update Lot

function showModelUpdatelot(id) {
    if (id != null && id != undefined) {
        $.get("/Lot/GetLot", { id: id }, function (result) {
            $("#uppurete").val(result.purete);
            $("#upconcentration").val(result.concentration);
            $("#updateperemption").val(result.datePeremption.substr(0, 10));
            $("#upstock").val(result.stock);
            sessionStorage.setItem("idLot", id);
            $("#ModelUpLot").modal("show");
        })
    }
    else {
        alertify.error("Cannot Show this Lot");
    }
}
function hideModelUpdateLot() {
    $("#ModelUpLot").modal("hide");
}

function UpdateLot() {
    class Lot {
        Purete;
        Concentration;
        DatePeremption;
        Stock;
        constructor() {
            this.Purete = $("#uppurete").val();
            this.Concentration = $("#upconcentration").val();
            this.DatePeremption = $("#updateperemption").val();
            this.Stock = $("#upstock").val();
        }
    }
    $.validator.unobtrusive.parse($("#upformlot"));
    if ($(upformlot).valid()) {
        if (sessionStorage.getItem("idLot") != 0 && sessionStorage.getItem("idLot") != undefined) {
            var Id = sessionStorage.getItem("idLot");
            $.post("/Lot/UpdateLot", { Id: Id, Lot: new Lot() }, function (result) {
                if (result.success) {
                    hideModelUpdateLot();
                    alertify.success(result.message);
                    setTimeout(function () { location.reload(); }, 1000);
                }
                else {
                    hideModelUpdateLot();
                    alertify.error(result.message);
                }
            });
        }
        else {
            alertify.error("Cannot update this Produit");
        }

    }
    else {
        return false;
    }

}

// Delete Lot

function hideModelDeleteLot() {
    $("#ModalDeleteLot").modal("hide");
}

function showModelDeleteLot(Id) {
    sessionStorage.setItem("idLot", Id);
    $("#ModalDeleteLot").modal("show");
}

function DeleteLot() {
    if (sessionStorage.getItem("idLot") != 0 && sessionStorage.getItem("idLot") != undefined) {
        var Id = sessionStorage.getItem("idLot");
        $.post("/Lot/DeleteLot", { Id: Id }, function (result) {
            if (result.success) {
                hideModelDeleteLot();
                alertify.success(result.message);
                setTimeout(function () { location.reload(); }, 1000);
            }
            else {
                hideModelDeleteLot();
                alertify.error(result.message);
            }
        });
    }
    else {
        alertify.error("Cannot delete this Produit");
    }
}

// Recherche lot
function RechercheLot() {
    $(document).ready(function () {
        function Contains(text_one, text_two) {
            if (text_one.indexOf(text_two) != -1)
                return true;
        }
        $("#search").keyup(function () {
            var searchText = $("#search").val().toLowerCase();
            $(".search").each(function () {
                if (!Contains($(this).text().toLowerCase(), searchText)) {
                    $(this).hide();
                }
                else {
                    $(this).show();
                }
            });
        });
    });
}

//Details

function hideModelDetailLot() {
    $("#ModalDetailLot").modal("hide");
}

function showModelDetailLot(id) {
    if (id != null && id != undefined) {
        $.get("/Lot/Details", { id: id }, function (result) {
            $("#reference").text(result.reference);
            $("#nom").text(result.nom);
            $("#formule").text(result.formule);
            $("#cas").text(result.cas);
            sessionStorage.setItem("idProduit", id);
            $("#ModalDetailLot").modal("show");
        })
    }
    else {
        alertify.error("Cannot Show this Lot");
    } 
}
/*                                        Gestion Mouvement                        */

//Add Mouvements
function showModelAddMouvement() {
    $("#ModelAddmouvement").modal("show");
}
function hideModelAddMouvement() {
    $("#ModelAddmouvement").modal("hide");

}

//var selectProd = $("#typprod").change(function () {
//    var rep = $("#typprod option:selected");
//    return rep;
//});

$("#typprod").change(function () {
    let rep = $("#typprod option:selected").val()
    $.post("/Mouvement/GetProduit", { Id: rep }, function (result) {


        if (result.type == 1) {
            $("#labPurete").show();
            $("#purete").show();

            $("#dateperemtion").show();
            $("#labpremtion").show();

            $("#concentration").show();
            $("#labconcent").show();
        }
        else {
            $("#purete").hide();
            $("#labPurete").hide();

            $("#dateperemtion").hide();
            $("#labpremtion").hide();

            $("#concentration").hide();
            $("#labconcent").hide();
        }    
    });
});

function AddMouvement() {
    

    var selectMvt = $("#typmouv").change(function () {
        var rep = $("#typmouv option:selected");
        return rep;
    });

    var selectProd = $("#typprod").change(function () {
        var rep = $("#typprod option:selected");
        return rep;
    });
    class Mouvement {
        TypeMvt;
        Raison;
        IdProduit;
        Quantite;
        Observation;
        DateMouvement;
        constructor() {
            this.TypeMvt = selectMvt.val();
            this.Raison = $("#raison").val();
            this.IdProduit = selectProd.val();
            this.Quantite = $("#quantite").val();
            this.Observation = $("#observation").val();
            this.DateMouvement = $("#DateMvt").val();
        }
    }

    class Lot {
        IdProduit;
        Purete;
        Concentration;
        DatePeremption;
        Stock;
        constructor() {
            this.IdProduit = selectProd.val();
            this.Purete = $("#purete").val();
            this.Concentration = $("#concentration").val();
            this.DatePeremption = $("#dateperemtion").val();
            this.Stock = $("#quantite").val();
        }
    }

    $.validator.unobtrusive.parse($("#formmvt"));
    if ($(formmvt).valid()) {

        $.post("/Mouvement/AddMouvement", { Lot: new Lot(), mouvement: new Mouvement() }, function (result) {
            if (result.success) {
                hideModelAddMouvement();
                alertify.success(result.message);
                setTimeout(function () { location.reload(); }, 1000);
            }
            else {
                hideModelAddMouvement();
                alertify.error(result.message);
            }
        });

       /*  var data1 = new FormData();
        var mouv = new Mouvement();
        data1.append("DateMouvement", mouv.Date);
        data1.append("Raison", mouv.Raison);
        data1.append("TypeMvt", mouv.TypeMvt);
        data1.append("IdProduit", mouv.IdProduit);
        data1.append("IdLot", mouv.IdLot);
        data1.append("Quantite", mouv.Quantite);
        data1.append("Observation", mouv.Observation);
        data1.append("IdProduit", mouv.IdProduit);

        var data2 = new FormData();
        var lot = new Lot();
        data2.append("IdProduit", lot.IdProduit);
        data2.append("Purete", lot.Purete);
        data2.append("Concentration", lot.Concentration);
        data2.append("DatePeremption", lot.DatePeremption);
        data2.append("Stock", lot.Stock);

        $.ajax({
            url: "/Mouvement/AddMouvement",
            type: "POST",
            data: data1, data2,
            contentType: false,
            cache: false,
            processData: false,
            success: function (msg) {
                alert(msg);
              hideModelAddMouvement();
                alertify.success(msg.message);
                setTimeout(function () { location.reload(); }, 1000);
            },
            error: function () {
                alert("error send images")
            }
        });*/
    }
    else {
        return false;
    }
}

// Delete Mouvement

function showModelDeleteMouvement(id) {
    sessionStorage.setItem("IdMouvement", id);
    $("#ModalDeleteMouvement").modal("show");
}

function hideModelDeleteMouvement() {
    $("#ModalDeleteMouvement").modal("hide");
}

function DeleteMouvement() {
    if (sessionStorage.getItem("IdMouvement") != 0 && sessionStorage.getItem("IdMouvement") != undefined) {
        var Id = sessionStorage.getItem("IdMouvement");
        $.post("/Mouvement/DeleteMouvement", { Id: Id }, function (result) {
            if (result.success) {
                hideModelDeleteMouvement();
                alertify.success(result.message);
                setTimeout(function () { location.reload(); }, 1000);
            }
            else {
                hideModelDeleteMouvement();
                alertify.error(result.message);
            }
        });
    }
    else {
        alertify.error("Cannot delete this mouvement");
    }
}

/* Update Mouvement

function showModelUpdateMouvement(id) {
    if (id != null && id != undefined) {
        $.get("/Mouvement/GetMouvement", { id: id }, function (result) {
            $("#updatemouv").val(result.dateMouvement.substr(0,10));
            $("#TypeMvt").val(result.typeMvt);
            $("#upraison").val(result.raison);
            $("#upquantite").val(result.quantite);
            $("#upobservation").val(result.observation);
            sessionStorage.setItem("idMouvement", id);
            $("#ModelUpdatemouvement").modal("show");
        })
    }
    else {
        alertify.error("Cannot Show this Mouvement");
    }
}
function hideModelUpdateMouvement() {
    $("#ModelUpdatemouvement").modal("hide");
}

function UpdateMouvement() {
    class Mouvementstock {
        DateMouvement;
        IdRespMvt;
        TypeMvt;
        Raison;
        Quantite;
        Observation;
        constructor() {
            this.IdRespMvt = $("#IdRespMvt").val();
            this.DateMouvement = $("#updatemouv").val();
            this.TypeMvt = $("#TypeMvt").val();
            this.Raison = $("#upraison").val();
            this.Quantite = $("#upquantite").val();
            this.Observation = $("#upobservation").val();
        }
    }
    $.validator.unobtrusive.parse($("#formmvtup"));
    if ($(formmvtup).valid()) {
        if (sessionStorage.getItem("idMouvement") != 0 && sessionStorage.getItem("idMouvement") != undefined) {
            var Id = sessionStorage.getItem("idMouvement");
            $.post("/Mouvement/UpdateMouvement", { Id: Id, mouv: new Mouvementstock() }, function (result) {
                if (result.success) {
                    hideModelUpdateMouvement();
                    alertify.success(result.message);
                    setTimeout(function () { location.reload(); }, 1000);
                }
                else {
                    hideModelUpdateMouvement();
                    alertify.error(result.message);
                }
            });
        }
        else {
            alertify.error("Cannot update this Mouvement");
        }

    }
    else {
        return false;
    }

}*/

// Recherche Mouvement
function RechercheMouvement() {
    $(document).ready(function () {
        function Contains(text_one, text_two) {
            if (text_one.indexOf(text_two) != -1)
                return true;
        }
        $("#search").keyup(function () {
            var searchText = $("#search").val().toLowerCase();
            $(".search").each(function () {
                if (!Contains($(this).text().toLowerCase(), searchText)) {
                    $(this).hide();
                }
                else {
                    $(this).show();
                }
            });
        });
    });
}