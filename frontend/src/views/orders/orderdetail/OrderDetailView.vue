<template>
    <div class="main">
        <nav-bar />
        <div class="card">
            <div class="card-header">
                <div class="card-header-title">
                    <title-page text="Dados" />
                </div>
                <div class="card-header-content">
                    <input-label
                        label="Descrição"
                        v-model="orderDetail.client"
                        :autoFocus="!this.$route.params.id"
                    />
                    <!-- <input-label
                        label="Data entrega:"
                        type="date"
                        v-model="orderDetail.deadline"
                    /> -->
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
                                <td>Descrição</td>
                                <td class="text-center">Qt</td>
                                <td v-if="approved" class="text-center">
                                    Total
                                </td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr
                                v-for="(item, index) in orderDetail.items"
                                :key="index"
                            >
                                <td class="text-limited">
                                    {{ item.description }}
                                </td>
                                <td class="text-right">{{ item.quantity }}</td>
                                <td v-if="approved" class="text-right">
                                    {{ item.price }}
                                </td>
                                <td class="table-action">
                                    <div @click="editProduct(item)">E X</div>
                                </td>
                            </tr>
                        </tbody>
                        <tfoot v-if="false">
                            <tr>
                                <td colspan="2">Total</td>
                                <td class="text-right">
                                    {{ orderDetail.totalOrder }}
                                </td>
                            </tr>
                        </tfoot>
                    </table>
                </div>
            </div>
            <div v-if="approved" class="card-payment">
                <div class="card-payment-title">
                    <title-page text="Pagamento" />
                </div>
                <div class="card-payment-content">
                    <table>
                        <thead>
                            <tr>
                                <td>Forma de pagamento</td>
                                <td class="text-center">Valor</td>
                                <td></td>
                            </tr>
                        </thead>
                        <tbody>
                            <tr
                                v-for="(payment, index) in orderDetail.payments"
                                :key="index"
                            >
                                <td>{{ payment.description }}</td>
                                <td class="text-right">{{ payment.value }}</td>
                                <td class="table-action">
                                    <div @click="editProduct">E X</div>
                                </td>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr>
                                <td>Total</td>
                                <td class="text-right">80,00</td>
                            </tr>
                        </tfoot>
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

        <div v-if="productDetail" :key="rerender" class="modal-product">
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
                            :options="avaliableProducts"
                            v-model="product.id"
                            @optionSelected="productSelected"
                        />

                        <!-- // ifs da vida -->

                        <select-custom
                            label="Tamanho do bolo"
                            defaultOption="Selecione o tamanho do bolo"
                            :options="sizes"
                            v-model="product.size"
                            @optionSelected="sizeSelected"
                        />

                        <!-- <select-custom
                            label="Quantidade"
                            defaultOption="Selecione a quantidade"
                            :options="quantities"
                            v-model="product.quantity"
                            @optionSelected="(val) => (product.quantity = val)"
                        /> -->

                        <input-label label="Tema" v-model="product.theme" />

                        <input-label
                            v-if="product.type == 'topo'"
                            label="Nome"
                            v-model="product.name"
                        />

                        <input-label
                            v-if="product.type == 'topo'"
                            label="Idade"
                            type="Number"
                            v-model="product.age"
                        />

                        <text-area label="Observação" v-model="product.note" />

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
                            @save-clicked="saveProduct"
                            @cancel-clicked="cancelProduct"
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
import orderService from "@/services/order-service";
import OrderDetail from "@/models/OrderDetail";
import Item from "@/models/Item";
import Orders from "@/models/Orders";
import data from "@/services/data.js";

export default {
    name: "OrderDetailView",
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
            orderDetail: new OrderDetail(),
            productDetail: false,
            keepAdding: true,
            orderPS: "",
            pics: null,
            product: new Item(),
            isNewProduct: false,
            isEditing: false,
            isViewing: false,
            isNew: false,
            approved: false,
            sizes: data.CakesSize,
            avaliableProducts: data.AvaliableProducts,
            quantities: data.Quantities,
            rerender: 0,
            // zero: "01topo",
        };
    },
    created() {
        let idOrder = this.$route.params.id;
        this.isNew = idOrder == null;

        if (!idOrder) return;

        this.getOrder();
    },

    methods: {
        getOrder() {
            let idOrder = this.$route.params.id;
            if (!idOrder) return;

            this.orderDetail = new OrderDetail(orderService.getById());
        },

        addProduct() {
            this.productDetail = !this.productDetail;
            this.isNewProduct = true;
        },
        saveProduct() {
            // se o produto for válido

            if (this.isNewProduct) {
                this.product.description = this.avaliableProducts.find(
                    (des) => des.value === this.product.id
                ).text;

                this.orderDetail.items.push(this.product);

                if (this.keepAdding) {
                    this.product = new Item();
                    this.rerender += 1;
                    return;
                }

                this.productDetail = !this.productDetail;
                return;
            }

            this.productDetail = !this.productDetail;
        },
        cancelProduct() {
            this.isNewProduct = false;
            this.productDetail = !this.productDetail;
        },
        editProduct(item) {
            this.isNewProduct = false;
            this.productDetail = !this.productDetail;
            this.product = item;
            // console.log(item);
        },
        saveOrder() {
            // salvar a ordem

            if (this.isNew) {
                orderService.create(
                    new Orders({
                        id: "1",
                        user: "doucuras",
                        client: this.orderDetail.client,
                        deadline: "2022-12-28",
                        status: "Aguardando aprovação da turquesa",
                    })
                );
            }

            this.$router.push({ name: "OrdersView" });
        },
        cancelOrder() {
            this.$router.push({ name: "OrdersView" });
        },
        productSelected(prod) {
            this.product.id = prod;

            this.product.type = this.avaliableProducts.find(
                (des) => des.value === this.product.id
            ).type;
        },
        sizeSelected(prod) {
            this.product.size = prod;
        },
    },
};
</script>

<style lang="scss" scoped>
.main {
    overflow: auto;
    padding-bottom: 70px;
}

.card .card-header {
    display: flex;
    flex-direction: column;
}

.card {
    margin: 5px;
}

.card-products-content,
.card-payment-content,
.card-header-content {
    margin: 5px 10px;
}

.modal-product-content {
    margin: 0 10px;
}

.card-footer {
    position: fixed;
    bottom: 5px;
    left: 5px;
    right: 5px;
    background-color: #fff;
}

.text-limited {
    max-width: 150px;
    text-overflow: ellipsis;
    white-space: nowrap;
    overflow: hidden;
}

.table-action {
    // display: flex;
    // flex-direction: row;
    text-align: center;
    width: 40px;
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
