var Entity = $("model").data("entity");
console.log(Entity);
var clienteEdit = new Vue({
    //Data
    data: {
        model: Entity,
        formulario: "#FormCliente",
    },
    //Metodos
    methods: {
        Save: function () {
            if (BValidateData(this.formulario)) {
                Loading.fire("Guardando...");
                axios.post("Cliente/Save", this.model).then(function (get) {
                    Loading.close();
                    var result = get.data;

                    if (result.CodeError == 0) {
                        Toast.fire({
                            icon: 'success',
                            title: 'Registro Guardado'
                        });
                        setTimeout(function () {
                            window.location.href = "../Cliente"
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
clienteEdit.$mount("#ClienteEdit");