var LinkedListObj = {
    data: [
        {val:10},
        {val:20},
        {val:30},
        {val:40},
        {val:50}
    ],

    exists: function (value) {
        for (let i=0; i<this.data.length; i++){
            if (this.data[i].val == value)
                return true;
        }

        return false;
    },

    enqueue: function (value) {
        let n = this.data.length
        if (n == 0) {
            this.data.push({val:value});
        }
        else if (this.exists(value)) {
            throw new Error("Cannot enqueue duplicates");
        }
        else if (this.data[0].val > value) {
            this.data.splice(0, 0, {val:value});
        }
        else {
            throw new Error("Cannot enqueue - value is not in order");
        }
    },


    push: function (value) {
        let n = this.data.length
        if (n == 0) {
            this.data.push({val:value});
        }
        else if (this.exists(value)) {
            throw new Error("Cannot push duplicates");
        }
        else if (this.data[n - 1].val < value) {
            this.data.push({val:value});
        }
        else {
            throw new Error("Cannot push - value is not in order");
        }
    },


    insert: function (value, index) {
        let n = this.data.length
        if (index == 0) {
            this.enqueue(value);
        }
        else if (index == n) {
            this.push(value);
        }
        else if (this.exists(value)) {
            throw new Error("Cannot insert duplicates");
        }
        else if (index > n) {
            throw new Error("Cannot insert out of boundaries");
        }
        else if (index == n - 1 && value > this.data[index - 1].val) { // insert before last
            this.data.splice(index, 0, {val:value});
        }
        else if (value > this.data[index - 1].val && value < this.data[index].val) { // insert in between
            this.data.splice(index, 0, {val:value});
        }
        else {
            throw new Error("Cannot insert - value is not in order");
        }
    },

    pop: function () {
        let n = this.data.length
        if (n == 0) {
            throw new Error("Cannot pop empty data");
        }
        else {
            this.data.pop();
        }
    },

    dequeue: function () {
        let n = this.data.length;
        if (n == 0) {
            throw new Error("Cannot dequeue empty data");
        }
        else {
            this.data.shift();
        }
    },

    remove : function (value, index) {
        let n = this.data.length;
        if (this.data[index].val != value) {
            console.log("Data not found");
        }
        else if (index == 0){
            this.dequeue();
        }
        else if (index == n-1){
            this.pop();
        }
        else {
            this.data.splice(index, 1);
        }
    },

    display : function(){
        let str = "[ "
        for (let i=0; i<this.data.length; i++){
            str+= this.data[i].val.toString()+ " ";
        }
        str += "]"

        console.log(str);
    }
};

