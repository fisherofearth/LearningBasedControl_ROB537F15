function [ y ] = SigmoidF( x )
%UNTITLED5 Summary of this function goes here
%   Detailed explanation goes here
    

    y = x;
    for i = 1 : size(x,1)
        for j = 1 : size(x,2)
            y(i,j) = 1/(1+(exp(1))^(-x(i,j)));
        end
    end
    
end

