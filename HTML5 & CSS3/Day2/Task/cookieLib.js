var cookieLib = {
    _data: {},

    init: function() {
        const cookies = document.cookie.split(';');
        for (let i = 0; i < cookies.length; i++) {
            const parts = cookies[i].split('=');
            const key = parts[0].trim();
            const value = parts[1];
            if (key) this._data[key] = value;
        }
    },

    setItem: function(key, value) {
        if (!key) return;
        this._data[key] = String(value);
        document.cookie = key + "=" + value + "; max-age=31536000"; 
        return this._data[key];
    },

    getItem: function(key) {
        return this._data.hasOwnProperty(key) ? this._data[key] : null;
    },

    removeItem: function(key) {
        document.cookie = key + "=;";
        return delete this._data[key];
    },

    clear: function() {
        for (let key in this._data) {
            this.removeItem(key);
        }
        this._data = {};
    }
};

cookieLib.init();