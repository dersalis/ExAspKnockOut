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

  // self.id = ko.observable("");
  self.firstName = ko.observable("");
  self.lastName = ko.observable("");
  self.city = ko.observable("");
  self.country = ko.observable("");
  self.phone = ko.observable("");
  self.email = ko.observable("");

  self.result = ko.computed(function(){
    return {
      //Id: null,
      FirstName: self.firstName(),
      LastName: self.lastName(),
      City: self.city(),
      Country: self.country(),
      Phone: self.phone(),
      Email: self.email(),
    }
  });

  self.save = function(){
    var resData = ko.toJSON(self.result());
    console.log(resData);
    $.ajax("/api/addresses", {
      data: ko.toJSON(self.result()),
      type: "post", 
      processData:false,
      contentType: "application/json; charset=utf-8",
      dataType:"json"
  })
  .done(function(msg){
    console.log(msg);
    window.location = "/home/index";
  })
  .fail(function(msg){
    console.log(msg);
  });
  }
}

ko.applyBindings(new tasksViewModel());