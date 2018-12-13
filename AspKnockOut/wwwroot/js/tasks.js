function Address(data){
  this.id = data.id;
  this.firstName = data.firstName;
  this.lastName = data.lastName;
  this.city = data.city;
  this.country = data.country;
  this.phone = data.phone;
  this.email = data.email;
}

function tasksViewModel(){
  var self = this;

  self.addressesList = ko.observableArray([]);
  self.showData = function(){
    $.getJSON("/api/addresses", function(allData) {
      var mappedAddresses = $.map(allData, function(item) { return new Address(item) });
      self.addressesList(mappedAddresses);
      // console.log(mappedAddresses);
    });
  }
  self.someText = "Jest OK!";

  self.showData();
}

ko.applyBindings(new tasksViewModel());