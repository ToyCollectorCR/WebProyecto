var Entity = $("model").data("entity");


console.log(Entity);

var productosEdit = new Vue({
    //Data
    data: {
        model: Entity,
        formulario: "#FormProductos",
    },
    //Metodos
    methods: {

        Save: function () {


            if (BValidateData(this.formulario)) {

                Loading.fire("Guardando...");
                axios.post("Productos/Save", this.model).then(function (get) {
                    Loading.close();
                    var result = get.data;

                    if (result.CodeError == 0) {
                        Toast.fire({
                            icon: 'success',
                            title: 'Registro Guardado'
                        });
                        setTimeout(function () {
                            window.location.href = "../Productos"
                        }, 1500)
                    } else {
                        Toast.fire({
                            icon: 'error',
                            title: result.MsgError
                        });
                    }

                });

            } else {

                Toast.fire({
                    icon: "error",
                    title: "Porfavor Complete los campos requeridos!"
                });
            }
        }

    },

    mounted: function () {
        CreateValidator(this.formulario);
    }
    //create


});


productosEdit.$mount("#ProductosEdit");
