var Login = new Vue({
    data: {
        Model: {
            Usuario: null,
            Contrasena: null,
        },//fin Model


    },//fin Data

    methods: {

        LoginUsuario: function () {
            Loading.fire("Login...");

            axios.post("/Login/LoginUser", this.Model).then(function (get) {
                var result = get.data;
                Loading.close();

                if (result.CodeError == 0) {
                    window.location.href = "/";
                } else {
                    Toast.fire({
                        icon: 'error',
                        title: result.MsgError
                    });
                }


            });

        },//fin LoginUsuario

    },//fin methods

});


Login.$mount("#LoginUsuario");