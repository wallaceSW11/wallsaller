<template>
    <div class="main">
        <nav-bar />
        <div class="card">
            <div class="card-header">
                <input-label label="Cliente:" />
                <input-label label="Data entrega:" type="date" />
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
                <div class="modal-product-header">Produtos</div>
                <div class="modal-product-content">
                    <select>
                        <option value="">Topo Especial</option>
                        <option value="">Topo Especial Nome-Idade</option>
                        <option value="">Caixa Explosão</option>
                    </select>
                    <select>
                        <option value="">10 cm</option>
                        <option value="">20 cm</option>
                        <option value="">30 cm</option>
                    </select>
                </div>
                <div class="modal-product-footer">
                    <button-save-cancel
                        @save-clicked="addProduct"
                        @cancel-clicked="addProduct"
                    />
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

export default {
    name: "OrderDetail",
    components: {
        InputLabel,
        NavBar,
        TitlePage,
        ButtonSaveCancel,
    },
    data() {
        return {
            productDetail: false,
        };
    },
    methods: {
        addProduct() {
            this.productDetail = !this.productDetail;
        },
        saveOrder() {
            this.$router.push({ name: "OrdersView" });
        },
        cancelOrder() {
            this.$router.push({ name: "OrdersView" });
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

.card-header {
    /* padding: 0 10px; */
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
.card-payment-content {
    margin: 10px;
}

tr {
    line-height: 25px;
}

.modal-main {
    display: flex;
    flex-direction: column;
    margin: 10px;
    background-color: #fff;
}

.modal-product {
    position: fixed;
    z-index: 99;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background: rgba(0, 0, 0, 0.8);
}
</style>
