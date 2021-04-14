


var RegistrarUsuario = new Vue({
    data: {
        Model: {
            Usuario: null,
            Contrasena: null,
            Nombre: null
        },//fin Model
        formulario: "#FormularioRegistrar"

    },//fin Data

    methods: {

        RegistrarUsuario: function () {

            if (BValidateData(this.formulario)) {
                Loading.fire("Registrando...");

                axios.post("/Login/RegistrarUsuario", this.Model).then(function (get) {
                    var result = get.data;
                    Loading.close();

                    if (result.CodeError == 0) {

                        Toast.fire({
                            icon: 'success',
                            title: "Su usuario se creo sastifactoriamente!"
                        }).then(function () {
                            window.location.href = "/Login";
                        });

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
        },//fin LoginUsuario

    },//fin methods

    mounted: function () {
        CreateValidator(this.formulario);
    },//fin Mounted

});


RegistrarUsuario.$mount("#RegistrarUsuario");