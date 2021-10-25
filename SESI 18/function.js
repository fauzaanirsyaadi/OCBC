
function removeSpaces(password) {
  const sentence = password.replace(/ /g, '').trim()
  return sentence;
}

function ReverseString(str) {   
  // Take empty array revArray
  const revArray = [];
  const length = str.length - 1;
    
  // Looping from the end
  for(let i = length; i >= 0; i--) {
      revArray.push(str[i]);
  }
  
  // Joining the array elements
  return revArray.join('');
}

// function ChangeOneAfterIt(password){
//   let panjang = password.length
//   for(let i = 0, i = password.length; i++){

//   }  
//   // const change = password.replace(/a/g, (s, i) => i > 1 ? 'z' : s)
//   const change = password.replace()
//   return change
// }


var password = "a b c d e"
// console.log("test "+ChangeOneAfterIt(password));
console.log("remove space "+removeSpaces(password))
console.log("reversed "+ReverseString(removeSpaces(password)))
// console.log("change one after it "+ChangeOneAfterIt(ReverseString(removeSpaces(password))))
// console.log(sentence)

