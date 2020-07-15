import data from '../data/attributes.json';
class Attribute{
    id:string;
    name:string;
    values:string[];
    constructor(id:string,theName:string,theValues:string[]){
        this.id=id;
        this.name=theName;
        this.values=theValues;
    }
    static getAll(){
        let arr:Attribute[];
        return data as Attribute[];
    }
}

export default Attribute;