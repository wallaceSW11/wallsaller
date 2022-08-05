<template>
    <div class="main">
        <nav-bar />
        <div class="card">
            <div class="card-header">
                <div class="card-header-title">
                    <title-page text="Dados" />
                </div>
                <div class="card-header-content">
                    <input-label label="Cliente:" />
                    <input-label label="Data entrega:" type="date" />
                </div>
            </div>
            <div class="card-products">
                <div class="card-products-title">
                    <title-page
                        text="Produtos"
                        add-icon
                        @icon-clicked="addProduct"
                    />
                </div>
                <div class="card-products-content">
                    <table class="product-table">
                        <thead>
                            <tr>
                                <td>Item</td>
                                <td>Qt</td>
                                <td>Total</td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>Topo especial</td>
                                <td>1</td>
                                <td>30,00</td>
                                <td>E X</td>
                            </tr>
                            <tr>
                                <td>Caixa explosão</td>
                                <td>1</td>
                                <td>45,00</td>
                                <td>E X</td>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr>
                                <td colspan="2">Total</td>
                                <td>75,00</td>
                            </tr>
                        </tfoot>
                    </table>
                </div>
            </div>
            <div class="card-payment">
                <div class="card-payment-title">
                    <title-page text="Pagamento" />
                </div>
                <div class="card-payment-content">
                    <table>
                        <thead>
                            <tr>
                                <td>Forma de pagamento</td>
                                <td>Valor</td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>PIX</td>
                                <td>75,00</td>
                                <td>E X</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            <div class="card-footer">
                <button-save-cancel
                    @save-clicked="saveOrder"
                    @cancel-clicked="cancelOrder"
                />
            </div>
        </div>

        <div v-if="productDetail" class="modal-product">
            <div class="modal-main">
                <div class="full">
                    <div class="modal-product-header">
                        <title-page
                            :text="
                                'Produto' +
                                (true ? ' - (cadastro)' : ' - (alteração)')
                            "
                        />
                    </div>
                    <div class="modal-product-content">
                        <select-custom
                            label="Produto"
                            defaultOption="Selecione o produto"
                            :options="internselectData"
                            @optionSelected="productSelected"
                        />

                        <!-- // ifs da vida -->

                        <select-custom
                            label="Tema"
                            defaultOption="Selecione o tema"
                            :options="theme"
                        />

                        <select-custom
                            label="Tamanho do bolo"
                            defaultOption="Selecione o tamanho do bolo"
                            :options="sizes"
                            @optionSelected="sizeSelected"
                        />

                        <input-label label="Quantidade" type="Number" />
                        <input-label label="Nome" />

                        <input-label label="Idade" type="Number" />

                        <text-area label="Observação" v-model="orderPS" />

                        <input-file label="Imagens de exemplo" v-model="pics" />
                    </div>
                </div>
                <div class="full">
                    <div class="modal-product-footer">
                        <checkbox-custom
                            text="Continuar adicionando"
                            v-model="keepAdding"
                            style="padding-bottom: 5px"
                        />
                        <button-save-cancel
                            @save-clicked="addProduct"
                            @cancel-clicked="addProduct"
                        />
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import InputLabel from "@/components/inputs/input/InputLabel.vue";
import NavBar from "@/components/navbar/NavBar.vue";
import TitlePage from "@/components/titles/title/TitlePage.vue";
import ButtonSaveCancel from "@/components/buttons/savecancel/ButtonSaveCancel.vue";
import SelectCustom from "@/components/select/select/SelectCustom.vue";
import CheckboxCustom from "@/components/inputs/checkbox/CheckboxCustom.vue";
import TextArea from "@/components/inputs/textarea/TextArea.vue";
import InputFile from "@/components/inputs/inputfile/InputFile.vue";

export default {
    name: "OrderDetail",
    components: {
        InputLabel,
        NavBar,
        TitlePage,
        ButtonSaveCancel,
        SelectCustom,
        CheckboxCustom,
        TextArea,
        InputFile,
    },
    data() {
        return {
            productDetail: true,
            keepAdding: true,
            orderPS: "",
            pics: [],
            internselectData: [
                {
                    value: "01topo",
                    text: "Topo Especial",
                },
                {
                    value: "02topo",
                    text: "Topo Especial - Nome e Idade",
                },
                {
                    value: "03caixa",
                    text: "Caixa explosão",
                },
            ],
            sizes: [
                {
                    value: "01",
                    text: "10 cm",
                },
                {
                    value: "02",
                    text: "15 cm",
                },
                {
                    value: "03",
                    text: "20 cm",
                },
            ],
            theme: [
                {
                    value: "01",
                    text: "Marsha",
                },
                {
                    value: "02",
                    text: "Mundo bita",
                },
                {
                    value: "03",
                    text: "Minicraft",
                },
            ],
        };
    },
    methods: {
        addProduct() {
            console.log(this.pics);

            if (!this.keepAdding) {
                this.productDetail = !this.productDetail;
            }
        },
        saveOrder() {
            this.$router.push({ name: "OrdersView" });
        },
        cancelOrder() {
            this.$router.push({ name: "OrdersView" });
        },
        productSelected(prod) {
            console.log(prod);
        },
        sizeSelected(prod) {
            console.log(prod);
        },
    },
};
</script>

<style lang="scss" scoped>
.card .card-header {
    display: flex;
    flex-direction: column;
}

.card {
    margin: 5px;
}

table {
    width: 100%;
    border-collapse: collapse;
}
thead {
    border-bottom: 1px solid $primaryColor;
    font-weight: bold;
    font-size: 16px;
}
table > tfoot {
    border-top: 1px solid $primaryColor;
}

.card-footer {
    position: absolute;
    bottom: 5px;
    left: 5px;
    right: 5px;
}

.card-products-content,
.card-payment-content,
.card-header-content {
    margin: 10px;
}

.modal-product-content {
    margin: 0 10px;
}

tr {
    line-height: 25px;
}

// modal styles

.modal-product {
    position: fixed;
    z-index: 99;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background: rgba(0, 0, 0, 0.8);
}

.modal-main {
    display: flex;
    flex-direction: column;
    margin: 10px;
    background-color: #fff;
    min-height: 95%;
    justify-content: space-between;
}

.modal-product-header {
    padding: 5px;
}

.full {
    display: flex;
    flex-direction: column;
}

.modal-product-footer {
    margin: 10px;
}
</style>
