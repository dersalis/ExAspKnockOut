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

  self.someText = "Jest OK!";

  $.getJSON("/api/tasks", function(allData) {
    var mappedAddresses = $.map(allData, function(item) { return new Address(item) });
    self.addressesList(mappedAddresses);
    // console.log(mappedAddresses);
  });
}

ko.applyBindings(new tasksViewModel());