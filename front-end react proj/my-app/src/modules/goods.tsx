import data from '../data/goods.json';
import AttributeWithValue from  "./atWValue"
import SortingMethods from "./sortingEnum"
const ElementsOnPage=8;

class ResponsePage{
    numOfEl:number;
    nextpage:boolean;
    nOfPages:number;
    elements:Good[];
    minPrice:number;
    maxPrice:number;
    constructor(num:number,npage:boolean,n:number,els:Good[],min:number,max:number){
        this.elements=els;
        this.nextpage=npage;
        this.nOfPages=n;
        this.numOfEl=num;
        this.minPrice=min;
        this.maxPrice=max;
    }
}
class Good{
    id:string;
    name:string;
    price:number;
    attributes:AttributeWithValue[];
    numberOfSizes:object;
    images:string[];
    constructor(id:string,theName:string,theAttributes:AttributeWithValue[],theNumbers:object,theImgs:string[],pr:number){
        this.price=pr;
        this.id=id;
        this.name=theName;
        this.attributes=theAttributes;
        this.numberOfSizes=theNumbers;
        this.images=theImgs;
    }
    static getAll(){
        return data as Good[];
    }
    static getById(id:string){
        let databayo:Good[]=this.getAll()
        return databayo.find((element, index, array)=>{
            if (element.id==id)
                return true
            else
                return false
        })
    }
    static getFiltratedGoods(attrs:AttributeWithValue[]){
        let goods:Good[] = this.getAll()
        let filtratedData:Good[]=[];
        attrs.map(attr=>{
            if (attr.name!="name"){
                goods.map(element => {
                    element.attributes.forEach(a=>{
                        if (a.name==attr.name){
                            if(attr.value.split(',').includes(a.value))
                                filtratedData.push(element)
                        }
                    })
                });
            }
            else{
                goods.forEach(element => {
                    if (element.name.includes(attr.value))
                        filtratedData.push(element)
                });
            }
            goods=filtratedData;
            filtratedData=[];
        })
        return goods;
    }
    static getGoodsPage(attrs:AttributeWithValue[],method:SortingMethods, page:number){
        let databayo:Good[]=this.getFiltratedAndSorted(attrs,method)
        let tocount=[...databayo]
        tocount.sort((a, b) => a.price < b.price ? 1 : -1);
        let len= databayo.length
        let min:number=-1;
        let max:number=-1;

        let n=Math.trunc(len/ElementsOnPage);
        if (len % ElementsOnPage>0)
            n++
        if (n==0)
            n=1
        if (databayo.length>0){
            min=tocount[0].price
            max=tocount[tocount.length-1].price
        }
        let next =false;
        let datalen=ElementsOnPage;
        if (len>(page-1)*ElementsOnPage){
            databayo=databayo.slice((page-1)*ElementsOnPage,Math.min(len,(page)*ElementsOnPage));
            console.log(databayo)
            if (len>(page)*ElementsOnPage)
                next=true;
            else
                datalen=len-(page-1)*ElementsOnPage
        }else{
            databayo=[]
            datalen=0
        }
        console.log(databayo)
        return new ResponsePage(datalen,next,n,databayo,min,max)
    }
    static getFiltratedAndSorted(attrs:AttributeWithValue[],method:SortingMethods){
        let databayo:Good[]=this.getFiltratedGoods(attrs)
        if (method==SortingMethods.Any)
            return databayo
        if (method==SortingMethods.Down){
            databayo.sort((a, b) => a.price < b.price ? 1 : -1);
            return databayo
        }
        if (method==SortingMethods.Up){
            databayo.sort((a, b) => a.price > b.price ? 1 : -1);
            return databayo
        }
        return [];
    }
    

}

export default Good;