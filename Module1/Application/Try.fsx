﻿#load "Types.fs"
#load "Functions.fs"

open Types
open Functions

let customer = { Id = 1; IsVip = false; Credit = 10M }
tryPromoteToVip (customer, 101M)
let calcualtedPurchases = getPurchases customer
