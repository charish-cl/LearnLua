---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by ForgotElk.
--- DateTime: 2024/7/25 8:30
---
--lua模拟类

local function class(className,super)

    local class = {__cname = className}
    local superType = type(super)
    if superType ~= "function" and superType ~= "table" then
        super = nil
    end
    if super then
        class.super = super
        class.ctor = function()
        end

        setmetatable(class, {__index = super})
    end

        return class
end
