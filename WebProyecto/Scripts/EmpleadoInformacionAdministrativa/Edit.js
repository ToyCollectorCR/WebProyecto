console.log(Entity);

var NuevoEmpleadoInformacionAdministrativa = new Vue({
    //Data
    data: {
        model: Entity,
        formulario: "#FormEmpleadoInformacionAdministrativa",
        ddlCanton: [],
        ddlDistrito: []
    },
    //Metodos
    methods: {

        Save: function () {

            if (BValidateData(this.formulario)) {

                Loading.fire("Guardando...");
                axios.post("Informacion/Save", this.model).then(function (get) {
                    Loading.close();
                    var result = get.data;

                    if (result.CodeError == 0) {
                        Toast.fire({
                            icon: 'success',
                            title: 'Registro Guardado'
                        });
                        setTimeout(function () {
                            window.location.href = "../Informacion"
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
        },//Fin de guardar

       OnChangeEmpleado: function () {
            var $this = this;
            Loading.fire("Cargando Empleado..");
            axios.post('Informacion/ddlEmpleado', this.model).then(function (get) {
                $this.ddlEmpleado = [];
                Loading.close();
                var result = get.data;
                $this.ddlCanton = result;
            });

        },//FinOnChangeProvincia

        /*OnChangeCanton: function () {
            var $this = this;
            Loading.fire("Cargando Distritos..");
            axios.post('Informacion/ddlDistrito', this.model).then(function (get) {
                $this.ddlDistrito = [];
                Loading.close();
                var result = get.data;
                $this.ddlDistrito = result;

            });

        },//Fin OnChangeCanton*/

    },

    mounted: function () {
        CreateValidator(this.formulario);
    }
    //create

});

NuevoInformacionPersonal.$mount("#NuevoEmpleadoInformacionAdministrativa");