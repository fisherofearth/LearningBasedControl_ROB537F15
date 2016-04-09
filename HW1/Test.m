function [ MSEl error ] = Test( testData, w_ji, w_j, w_jk, w_k )
%UNTITLED Summary of this function goes here
%   Detailed explanation goes here
MSEl = 0;
error = 0;
for n = 1 : size(testData,1)
    xx = testData(n,1:5)';
    yy = testData(n,6:7)';

    hj = SigmoidF(w_ji*xx + w_j); 
    yy_hat = SigmoidF(w_jk'*hj + w_k); 

    ee_k = yy - yy_hat;

    MSEl = MSEl + sum(abs(ee_k));
    ev1 = abs(yy_hat(1,1) - 0.5);
    ev2 = abs(yy_hat(2,1) - 0.5);
    if ev1 > ev2
        if yy_hat(1,1) > 0.5
            tt = [1;0];
        else
            tt = [0;1];
        end
    else
        if yy_hat(2,1) > 0.5
            tt = [0;1];
        else
            tt = [1;0];
        end
    end
    if (yy - tt) == [0;0] 
    else
        error = error + 1;
    end
end

end

