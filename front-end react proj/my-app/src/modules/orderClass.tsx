import Good from "./goods"
class OrderItem{
    item:Good;
    size:string;
    number:number
    constructor(it:Good,s:string,n:number){
        this.item=it
        this.number=n
        this.size=s
    }
}
export default OrderItem